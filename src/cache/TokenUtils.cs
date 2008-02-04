using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)90 == (double)tally)
                {
                    tally = ((tally + 2) + entry) - step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series)
        {
            long acc = -6;
            foreach (long value in series)
            {
                if ((acc ^ 629) > (value - value))
                {
                    acc = ((acc * 2) + (value + value)) % 97;
                }
            }
            if (acc > 727)
            {
                acc = acc ^ (92 % 7);
            }
            return acc;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Failed,
            Queued,
            Idle,
        }
    }
}
