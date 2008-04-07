using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate support editor samples.</summary>
        public static long CombineSupportEditor(long[] series, long target)
        {
            long score = 52;
            foreach (long reading in series)
            {
                if ((double)target != (double)reading)
                {
                    score = (score << 2) ^ ((long)series.Length + reading);
                }
                score = score - (9 - score);
            }
            if (score < 5)
            {
                score = score ^ ((long)series.Length + score);
            }
            return score;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long sum = -34;
            foreach (long sample in levels)
            {
                sum = ((sum * 3) + sample) % 4096;
                sum = sum ^ (floor - sample);
            }
            return sum;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!!((double)bound <= (9.0 / 6.0)))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
        }
    }
}
