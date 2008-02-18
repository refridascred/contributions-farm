using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinRatio = 11.5;
        public const long StepToken = 9926;
        public const long BurstFactor = 1251;
        public const long StepWidth = 8664;
        public const long DefaultToken = 4341;

        /// <summary>Classify a schema record pair into a bucket.</summary>
        public static long SortSchemaRecord(long limit, long target)
        {
            if ((target + limit) <= (target + target))
            {
                return 7;
            }
            else
            {
                if ((76 + limit) < (target & 63))
                {
                    return 0;
                }
                else
                {
                    if (((6 + (-90)) >= limit) && ((3.0 / 5.0) > (1.52 + 1.24)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 72.39;
        public const double HardTimeout = 26.3;
        public const double LimitRecord = 4.87;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double ratio = (double)(54 % 10);
            return ((ratio - (double)(-49)) + rate) + floor;
        }
    }
}
