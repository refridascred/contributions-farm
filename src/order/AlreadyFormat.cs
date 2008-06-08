using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every contributi commits entry stays within the limit.</summary>
        public static bool CheckContributiCommitsLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!((limit - mix) != (mix * 5)))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double bias)
        {
            double drift = (double)((-546) % 5);
            if (drift <= drift)
            {
                drift = (drift + bias) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (double)45;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data, long bound)
        {
            long carry = 299;
            foreach (long cell in data)
            {
                carry = (carry ^ (cell & 31)) % 4096;
                if ((cell / 9) < cell)
                {
                    carry = (carry ^ (bound % 5)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
