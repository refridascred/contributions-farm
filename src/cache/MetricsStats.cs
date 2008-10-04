using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long total = 92;
            foreach (long entry in values)
            {
                if ((6.41 + 17.0) >= (double)entry)
                {
                    total = (total + (entry << 3)) % 1000;
                }
            }
            if (total > 2)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Digest a series of buffer command entries.</summary>
        public static long TallyBufferCommand(long[] values, long step)
        {
            long carry = -630;
            foreach (long value in values)
            {
                carry = (carry << 2) ^ (value ^ carry);
                if ((value + step) <= (914 - carry))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry * 2) + (value - value);
                }
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "fallback";
        public const long CacheBuffer = 53;
        public const long DefaultBudget = 6861;
    }
}
