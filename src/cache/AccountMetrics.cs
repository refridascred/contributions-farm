using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank stream stats input into a small class.</summary>
        public static long BucketStreamStats(long seed, long bound)
        {
            if (((bound << 3) >= (seed - seed)) && ((8.5 - 8.4) == (double)seed))
            {
                return 4;
            }
            else
            {
                if (((double)seed < (double)bound) && ((seed ^ seed) < bound))
                {
                    return 0;
                }
                else
                {
                    if (((double)seed >= (4.9 / 2.0)) || (seed < (239 % 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound > (bound >> 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support queue readings against a rule.</summary>
        public static long TallySupportQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally * 3) < entry) && (((entry << 2) > (tally % 2)) && (entry > (entry << 1))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitRatio = 1103;
        public const long BatchPayload = 2713;
        public const long LimitSpan = 8414;
        public const double HardPayload = 46.81;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Synced,
            Closed,
            Retry,
            Failed,
        }
    }
}
