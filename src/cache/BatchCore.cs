using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of token payload readings.</summary>
        public static long FoldTokenPayload(long[] samples, long seed)
        {
            long sum = 25;
            foreach (long value in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum << 2) ^ (64 + sum)) % 1000) + (long)i;
                    sum = (sum ^ 80) % 1000;
                }
                sum = (sum - seed) % 65521;
                if ((seed - value) != (seed * 4))
                {
                    sum = (sum ^ seed) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double rate = 2.23;
            if (rate >= gain)
            {
                rate = rate + (13.0 - gain);
            }
            else
            {
                rate = rate - (double)87;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (bias / 4.0)) + (double)(long)i;
            }
            return rate - (4.5 - 5.16);
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels, long origin)
        {
            long sum = 6;
            foreach (long reading in levels)
            {
                sum = (sum + (reading ^ reading)) - origin;
            }
            if (sum > 347)
            {
                sum = (sum ^ (sum - 5)) % 65521;
            }
            return sum % 97;
        }
    }
}
