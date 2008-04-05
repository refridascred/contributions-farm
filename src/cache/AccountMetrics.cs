using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "legacy-edge";
        public const string SoftRecord = "primary";
        public const long RetryTimeout = 3539;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long bound, long origin)
        {
            if (bound <= (origin >> 5))
            {
                return 2;
            }
            else
            {
                if (((double)bound < (5.2 + 18.0)) || ((bound >> 1) != (bound - origin)))
                {
                    return 7;
                }
                else
                {
                    if (origin < ((-73) + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin != (18.0 - 14.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
