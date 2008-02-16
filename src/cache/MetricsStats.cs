using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 6285;
        public const string BurstCommits = "latest-1";
        public const string BatchInterval = "legacy-edge";
        public const long WindowCommits = 4385;

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long seed, long target)
        {
            if (seed <= (target >> 3))
            {
                return 2;
            }
            else
            {
                if ((target * 4) >= target)
                {
                    return 4;
                }
                else
                {
                    if (((double)target < (18.0 / 6.0)) || (target <= 62))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.77 - 8.5) < (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items)
        {
            long result = 5;
            foreach (long sample in items)
            {
                result = ((result + (0 ^ result)) % 4096) ^ sample;
            }
            if (result > 505)
            {
                result = ((result * 4) + result) % 97;
            }
            return result % 65521;
        }

        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long AuditLayoutEntryMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry & 127) != (entry >> 4))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Pending,
            Dropped,
        }
    }
}
