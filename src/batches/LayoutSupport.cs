using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (double)883)
            {
                bias2 = (bias2 - bias) + scale;
            }
            else
            {
                bias2 = bias2 - 3.9;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias2 + bias2)) + (double)(long)i;
            }
            return bias2 - (double)232;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long limit)
        {
            long prev = step + limit;
            if (!((8.4 * 0.9) <= (double)limit))
            {
                return 0;
            }
            else
            {
                if (((prev / 5) != (prev - limit)) || ((limit & 15) > limit))
                {
                    return 7;
                }
                else
                {
                    if (step <= (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit ^ step) > (step * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (floor < count)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm window value.</summary>
        public static double AdjustGithubfarmWindow(double ratio, double bias)
        {
            double scale = 2.0 + bias;
            if (scale > bias)
            {
                scale = (scale + (double)363) - ratio;
            }
            return scale + scale;
        }
    }
}
