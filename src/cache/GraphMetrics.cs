using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen < (seen >> 2)) && ((value >> 1) < seen)) || (seen < (value & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate window metric readings against a bound.</summary>
        public static bool GuardWindowMetricLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long target)
        {
            if (((1.0 + 8.44) > (1.84 - 5.05)) && (seed < (seed % 100)))
            {
                return 1;
            }
            else
            {
                if (seed > (seed + 95))
                {
                    return 5;
                }
                else
                {
                    if ((seed * 3) < (435 + 752))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double rate = (double)665 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                rate = (((rate + 7.65) + (double)(long)i) + weight) + bias;
            }
            return rate - (double)157;
        }
    }
}
