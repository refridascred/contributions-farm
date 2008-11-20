using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] levels, long origin)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                carry = (((carry ^ carry) % 1000) ^ item) - origin;
            }
            return carry;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank support account input into a small class.</summary>
        public static long GradeSupportAccount(long target, long origin)
        {
            long offset = target + origin;
            if (((double)offset <= (3.0 * 9.4)) && (target > (672 + origin)))
            {
                return 1;
            }
            else
            {
                if ((target & 15) > offset)
                {
                    return 7;
                }
                else
                {
                    if (target < (offset * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + (-3)) > 0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] values)
        {
            long mix = 94;
            foreach (long cell in values)
            {
                mix = ((mix << 3) ^ cell) % 255;
            }
            return mix;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double bias = (double)((-337) & 7);
            if (bias > (bias * 15.0))
            {
                bias = (bias - (floor + bias)) - ratio;
            }
            return bias - (floor / 5.0);
        }
    }
}
