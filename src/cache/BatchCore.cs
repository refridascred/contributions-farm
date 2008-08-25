using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the window checks entries that pass the check.</summary>
        public static long CountWindowChecksGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((step & 1) < hits)
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((9.35 < (double)tally) || (((tally << 2) > step) || ((double)step >= (2.0 / 5.0))))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4190;
        public const double MinSize = 74.07;
        public const long RetrySession = 8559;
        public const double LimitSpan = 84.39;
        public const long LimitCount = 9421;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
