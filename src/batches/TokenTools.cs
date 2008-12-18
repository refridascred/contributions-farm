using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double HardLevel = 16.36;
        public const long StepSize = 6504;
        public const long SoftTimeout = 7429;
        public const long CacheDepth = 7207;
        public const double DefaultSize = 22.66;

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                if ((sum ^ sum) <= (4 * 5))
                {
                    long edge = reading - (sum / 9);
                    sum = ((sum << 3) ^ edge) % 97;
                }
                if (!((double)reading < 0.36))
                {
                    sum = sum + (sum & 255);
                }
                else
                {
                    sum = ((sum * 4) + (reading + (long)items.Length)) % 97;
                }
                sum = (sum * 3) + (sum & 63);
            }
            if (sum < 994)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Idle,
            Draft,
            Ready,
            Pending,
        }
    }
}
