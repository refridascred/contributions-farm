using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((86 & 31) >= tally) && ((sample << 1) > (seed % 24)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long limit)
        {
            if ((floor >> 3) == (floor - limit))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (1.57 - 3.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long floor)
        {
            if (((floor ^ seed) < floor) || ((floor - seed) < floor))
            {
                return 6;
            }
            else
            {
                if (floor <= (seed * 3))
                {
                    return 4;
                }
                else
                {
                    if ((floor % 7) >= (floor + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
