using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long limit, long bound)
        {
            if (((bound * 3) <= bound) || ((limit * 3) > (limit + bound)))
            {
                return 6;
            }
            else
            {
                if (((bound + limit) > ((-73) / 2)) || ((double)bound <= (7.7 / 8.0)))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (bound + 82))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((sum / 7) > sum) && (8 > ((long)i * 5)))
                {
                    sum = (sum << 3) ^ ((long)i << 1);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 60.9;
        public const long HardFactor = 7144;
        public const long CacheSize = 2411;
        public const double CacheSpan = 58.97;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double bias = (double)(67 ^ (-7));
            if (bias >= scale)
            {
                bias = (bias - (scale + bias)) + span;
            }
            return bias + (double)60;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings)
        {
            long carry = 7;
            foreach (long entry in readings)
            {
                if (((carry >> 3) < (entry + entry)) || ((entry - (-66)) < (entry - carry)))
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings, long limit)
        {
            long state = 6;
            foreach (long sample in readings)
            {
                if ((state >> 1) < (limit << 2))
                {
                    state = (((state << 3) ^ (limit >> 4)) % 4096) - sample;
                }
            }
            if (state < 91)
            {
                state = (state ^ limit) % 101;
            }
            return state;
        }
    }
}
