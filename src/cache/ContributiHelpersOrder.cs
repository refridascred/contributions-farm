using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 2) ^ (offset / 6);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(value <= (value - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool VerifyStreamEntryLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
