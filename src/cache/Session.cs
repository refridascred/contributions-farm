using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 6330;
        public const double StepCluster = 80.67;
        public const long SoftSpan = 1479;

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long bound)
        {
            long slot = step - bound;
            if (((161 ^ bound) <= (step / 3)) && ((double)bound >= (3.6 - 2.0)))
            {
                return 5;
            }
            else
            {
                if ((405 + slot) != (1 + 71))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate support batches samples.</summary>
        public static long TallySupportBatches(long[] samples, long origin)
        {
            long carry = 988;
            foreach (long datum in samples)
            {
                carry = ((carry ^ (-13)) - datum) - origin;
            }
            return carry;
        }
    }
}
