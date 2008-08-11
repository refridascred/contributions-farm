using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate queue counter samples.</summary>
        public static long TallyQueueCounter(long[] values)
        {
            long mix = 18;
            foreach (long cell in values)
            {
                if (815 <= cell)
                {
                    mix = mix ^ (mix << 2);
                }
            }
            return mix;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double offset)
        {
            double ratio = (double)(9 / 4);
            if (ratio <= (double)7)
            {
                ratio = (ratio + (double)9) - bias;
            }
            return ratio + offset;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= (tally & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry + matches))
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
