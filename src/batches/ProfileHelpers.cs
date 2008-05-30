using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a stream token reading.</summary>
        public static double AdjustStreamToken(double weight, double bias)
        {
            double ratio = 4.2;
            if (ratio <= (double)51)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio + (double)73;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of batch cluster readings.</summary>
        public static long TallyBatchCluster(long[] samples, long floor)
        {
            long carry = 42;
            foreach (long cell in samples)
            {
                if (1.2 <= (double)carry)
                {
                    carry = (((carry << 2) ^ (0 & 63)) % 1000) + cell;
                }
            }
            if (carry < 22)
            {
                carry = carry + floor;
            }
            return carry;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Draft,
            Idle,
            Ready,
        }
    }
}
