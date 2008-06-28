using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit window queue readings against a rule.</summary>
        public static long MeasureWindowQueueOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample % 2) <= (62 + sample))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of order route readings.</summary>
        public static long MatchOrderRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2940;
        public const double MinCommits = 63.21;
        public const long BatchCommits = 491;
    }
}
