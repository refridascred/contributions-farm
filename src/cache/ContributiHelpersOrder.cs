using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result * 3) + (bound - 960)) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next layout batch value from a seed.</summary>
        public static long DeriveLayoutBatch(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (sum % 60)) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
