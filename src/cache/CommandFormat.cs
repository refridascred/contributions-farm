using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value & 1) != (value / 9))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double scale = span;
            return (scale + scale) + weight;
        }

        /// <summary>Combine tools report values into a single score.</summary>
        public static long CombineToolsReport(long[] samples, long offset)
        {
            long sum = 975;
            foreach (long item in samples)
            {
                if ((double)offset < (double)item)
                {
                    sum = (sum ^ (sum % 64)) % 1000;
                }
            }
            if (sum > 4)
            {
                sum = sum ^ (offset << 3);
            }
            return sum;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            if (!((9 - bound) > (step ^ step)))
            {
                return 6;
            }
            else
            {
                if (bound < (bound / 3))
                {
                    return 2;
                }
                else
                {
                    if ((step - bound) <= (bound / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        if (79 > (step >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
