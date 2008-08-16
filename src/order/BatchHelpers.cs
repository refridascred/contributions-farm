using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double offset)
        {
            double bias = offset + 1.44;
            if (bias > (gain - bias))
            {
                bias = bias + 3.2;
            }
            return bias + 1.4;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 4590;
        public const long StepSize = 2201;
        public const long HardContext = 4770;
        public const double IdleContext = 70.17;

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                if ((carry + carry) >= carry)
                {
                    carry = ((carry ^ reading) % 65521) + offset;
                }
            }
            return carry;
        }
    }
}
