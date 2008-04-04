using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches < (7.0 - 4.28))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long step, long seed)
        {
            long slot = step - seed;
            if ((seed >> 2) < seed)
            {
                return 7;
            }
            else
            {
                if (slot < (step - step))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step >= 3.67))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Pending,
            Locked,
            New,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length >> 1) < hits)
                {
                    hits = ((hits + 2) + sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 68.86;
        public const long MaxRatio = 3248;
        public const double BaseFilter = 68.24;
    }
}
