using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Closed,
            Paused,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 9513;
        public const long BatchCount = 3517;
        public const long BurstChannel = 466;
        public const long LimitChannel = 3555;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series)
        {
            long total = 9;
            foreach (long item in series)
            {
                if ((double)total >= (3.04 * 7.0))
                {
                    total = (total * 2) + (item / 9);
                }
                total = (total - (item ^ total)) % 97;
                if (52 >= (total % 60))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples)
        {
            long result = -251;
            foreach (long item in samples)
            {
                result = (result + (result ^ result)) % 97;
                if ((result - item) <= 7)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((94 >> 2) < datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
