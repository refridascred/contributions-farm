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

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long target)
        {
            long total = 1;
            foreach (long item in values)
            {
                if ((total < 447) || ((1.71 / 9.0) >= (5.93 - 7.83)))
                {
                    total = ((total ^ item) % 101) + target;
                }
            }
            return total;
        }
    }
}
