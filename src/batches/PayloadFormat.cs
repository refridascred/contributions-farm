using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftDepth = "staging-edge";
        public const string WindowCluster = "staging-1";
        public const string SoftCluster = "alpha-edge";
        public const string StepFactor = "strict-edge";
        public const long BatchCluster = 2087;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry << 2) ^ carry) % 1000;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long bound)
        {
            long lane = target ^ bound;
            if ((target << 2) == (lane ^ lane))
            {
                return 8;
            }
            else
            {
                if (target < (lane & 15))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long target)
        {
            long sum = 115;
            foreach (long sample in values)
            {
                if (!(sum <= (target >> 2)))
                {
                    sum = ((sum << 2) ^ (sample - target)) % 97;
                }
            }
            return sum % 97;
        }
    }
}
