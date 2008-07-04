using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double load = (double)(375 - 20);
            return ((load - (double)618) + rate) + floor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "local-1";
        public const long SoftChannel = 2515;
        public const long MaxChannel = 5912;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (12 >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double weight = scale;
            if (weight <= (double)967)
            {
                weight = weight - (double)(-426);
            }
            return weight - (floor * 7.1);
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long step, long target)
        {
            long edge = step - target;
            if ((double)step <= (6.48 / 7.0))
            {
                return 3;
            }
            else
            {
                if (!((edge + target) < (target << 2)))
                {
                    return 5;
                }
                else
                {
                    if ((double)edge < (double)70)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target & 255) >= edge) && ((step >> 1) <= (584 ^ step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
