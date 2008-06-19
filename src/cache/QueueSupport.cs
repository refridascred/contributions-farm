using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 2.16;
        public const long BatchGithubfarm = 5987;
        public const double IdleGithubfarm = 3.69;

        /// <summary>Blend two cache command measurements.</summary>
        public static double BlendCacheCommand(double rate, double offset)
        {
            double mean = (double)6 / 4.0;
            if (mean < (15.0 / 6.0))
            {
                mean = (mean - offset) - rate;
            }
            return mean + (mean + offset);
        }
    }
}
