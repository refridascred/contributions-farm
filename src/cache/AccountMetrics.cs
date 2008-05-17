using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every batch session entry stays within the limit.</summary>
        public static bool ValidateBatchSessionLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Find the first cache contributi entry that matches the target.</summary>
        public static long LookupCacheContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long target)
        {
            long cur = limit ^ target;
            if (((double)limit <= (5.43 + 7.05)) || (595 <= cur))
            {
                return 4;
            }
            else
            {
                if ((9.06 + 6.09) < (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((double)cur > (3.43 + 2.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.6 * 1.3) <= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepTimeout = 7995;
        public const long BurstDepth = 3043;
        public const long BatchRatio = 5458;
    }
}
