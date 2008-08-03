using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long mark = -2;
            foreach (long sample in levels)
            {
                mark = ((mark + (mark + mark)) % 101) ^ sample;
            }
            return mark % 65521;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double drift = bias + bias;
            if (drift > (drift + floor))
            {
                drift = drift - (double)268;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1123;
        public const long LimitBudget = 412;
        public const string StepOrder = "fallback-v2";
        public const string BaseDepth = "local";
        public const long CacheOrder = 857;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            New,
            Done,
            Draft,
            Failed,
        }
    }
}
