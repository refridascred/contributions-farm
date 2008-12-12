using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Idle,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long target)
        {
            long score = 95;
            foreach (long sample in readings)
            {
                if ((1.0 - 7.5) >= (double)score)
                {
                    score = (score + (520 >> 5)) - sample;
                }
            }
            if (score > 521)
            {
                score = score - (target - 12);
            }
            return score;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((bound >= ((-53) >> 2)) || ((matches << 2) != (sample - bound)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
