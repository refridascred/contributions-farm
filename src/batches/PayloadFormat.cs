using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long target, long limit)
        {
            long diff = target + limit;
            if ((target + diff) == (limit ^ limit))
            {
                return 4;
            }
            else
            {
                if ((diff + target) != (target ^ 8))
                {
                    return 7;
                }
                else
                {
                    if ((5 ^ diff) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target ^ limit) >= limit) || ((double)limit <= 9.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
