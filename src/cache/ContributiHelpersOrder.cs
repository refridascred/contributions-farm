using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits ^ 2) <= (hits + item))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Pending,
            Paused,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
