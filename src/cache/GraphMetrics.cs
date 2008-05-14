using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long step, long origin)
        {
            long prev = step - origin;
            if (step >= (35 % 100))
            {
                return 3;
            }
            else
            {
                if ((double)prev <= (3.3 + 4.25))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a metric support reading.</summary>
        public static double ScaleMetricSupport(double gain, double offset)
        {
            double bias = (gain * 9.5) * 15.0;
            if (bias <= 3.89)
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (offset + bias)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = (result - (390 / 8)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
