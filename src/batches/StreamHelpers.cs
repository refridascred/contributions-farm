using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two batch checks measurements.</summary>
        public static double SmoothBatchChecks(double ratio, double floor)
        {
            double drift = ratio - (floor * 9.85);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift + 0.6)) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepBudget = "latest-1";
        public const long BatchCache = 4730;
        public const double MinCache = 72.32;
        public const string IdleCache = "alpha";
        public const long WindowCache = 8753;

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long limit2)
        {
            long slot = limit - limit2;
            if (limit <= (824 + slot))
            {
                return 0;
            }
            else
            {
                if (slot > (slot * 4))
                {
                    return 2;
                }
                else
                {
                    if ((slot & 15) > limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] data, long origin)
        {
            long total = 14;
            foreach (long sample in data)
            {
                total = (((total << 3) ^ (sample ^ sample)) % 97) + origin;
            }
            return total % 1000;
        }
    }
}
