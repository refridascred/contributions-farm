using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next cluster metrics value from a seed.</summary>
        public static long StepClusterMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] values)
        {
            long carry = 717;
            foreach (long reading in values)
            {
                if (carry <= (reading / 9))
                {
                    carry = (carry + (carry ^ reading)) % 97;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ (carry >> 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every order metrics entry stays within the limit.</summary>
        public static bool VerifyOrderMetricsBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
