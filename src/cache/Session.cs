using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "legacy";
        public const string StepBudget = "local-1";
        public const double LimitInterval = 7.98;
        public const long IdleDepth = 6238;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCount = 8031;
        public const string DefaultCount = "legacy-edge";
        public const long MinCounter = 3276;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long carry = 1;
            foreach (long value in items)
            {
                if ((double)value < (9.8 / 5.0))
                {
                    carry = (carry - (1 + carry)) % 255;
                    break;
                }
                else
                {
                    carry = ((carry * 4) + (value / 8)) % 4096;
                    carry = (carry + (value / 7)) % 4096;
                }
                carry = carry ^ (value >> 3);
                carry = ((carry << 3) ^ (carry - value)) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two profile editor measurements.</summary>
        public static double BlendProfileEditor(double weight, double floor)
        {
            double weight2 = 17.0;
            if (weight2 < floor)
            {
                weight2 = weight2 + (weight2 + floor);
            }
            else
            {
                weight2 = weight2 - (floor - weight2);
            }
            return weight2 - weight;
        }
    }
}
