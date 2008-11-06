using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i ^ carry) >= (carry & 127))
                {
                    carry = (carry + ((-261) / 7)) % 4096;
                }
                else
                {
                    carry = carry ^ carry;
                    carry = carry - ((long)i - bound);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double gain, double floor)
        {
            double load = floor;
            if (load >= (double)44)
            {
                load = load - (double)(-356);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (gain * 6.0)) + (double)(long)i;
            }
            return load - (gain - gain);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFactor = 34.63;
        public const long BurstScore = 15;
        public const long LimitFormat = 2059;
    }
}
