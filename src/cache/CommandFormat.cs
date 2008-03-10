using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a order profile figure with a bias.</summary>
        public static double BlendOrderProfile(double gain, double bias)
        {
            double bias2 = 6.55;
            if (bias2 >= (double)26)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (double)15) - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] samples)
        {
            long carry = 34;
            foreach (long cell in samples)
            {
                if ((carry + cell) >= (0 ^ 427))
                {
                    carry = carry + ((-499) + cell);
                }
            }
            if (carry > 56)
            {
                carry = (carry - (carry % 64)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 39.35;
        public const long CacheContext = 2208;
        public const long WindowSize = 6865;
        public const long HardContext = 138;
    }
}
