using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            New,
            Idle,
            Synced,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (long)i) % 4096;
                if (((sum >> 3) >= (offset & 127)) && (0.67 < (double)offset))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series, long floor)
        {
            long result = 92;
            foreach (long value in series)
            {
                result = ((result + (floor >> 5)) % 101) - value;
            }
            return result % 65521;
        }
    }
}
