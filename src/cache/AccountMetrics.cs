using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long target)
        {
            long gap = floor - target;
            if (floor > (gap ^ 993))
            {
                return 8;
            }
            else
            {
                if (floor > (target + target))
                {
                    return 4;
                }
                else
                {
                    if (!(target < (floor + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)gap < (double)3)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i >= offset) || ((13.0 - 1.2) == (double)(long)i)))
                {
                    result = (result + result) % 4096;
                }
                if (result > (offset - offset))
                {
                    result = result - (offset + offset);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Blend two support report measurements.</summary>
        public static double SmoothSupportReport(double gain, double floor)
        {
            double bias = 1.57;
            if (bias > 14.0)
            {
                bias = (bias + (floor * 0.5)) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (8.4 / 8.0)) + (double)(long)i;
            }
            return bias + (floor - 5.5);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 37.96;
        public const string LimitBudget = "alpha-edge";
        public const long DefaultCache = 9440;
    }
}
