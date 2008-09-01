using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a cache window counter forward.</summary>
        public static long StepCacheWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                long gap = (offset & 127) - offset;
                if (!((17.0 + 20.0) == (double)(long)i))
                {
                    gap = ((gap * 3) + (offset % 5)) % 97;
                }
                if (gap <= (state + (long)i))
                {
                    state = state - ((long)i * 5);
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two schema counter measurements.</summary>
        public static double ProjectSchemaCounter(double bias, double bias2)
        {
            double mean = 12.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + bias2) + (double)(long)i) - bias;
            }
            return mean + (bias2 - bias2);
        }
    }
}
