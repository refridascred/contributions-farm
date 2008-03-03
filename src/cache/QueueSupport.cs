using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double mean = floor - floor;
            return mean + (ratio / 8.0);
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry * 4) + ((long)i ^ limit);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryRatio = "standard-edge";
        public const long DefaultScore = 5750;
        public const long SoftScore = 609;
    }
}
