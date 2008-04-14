using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - (bias2 * 7.64)) + bias;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool ValidateQueueWindowLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a notes graph pair into a bucket.</summary>
        public static long SortNotesGraph(long floor, long floor2)
        {
            if (((floor << 2) < (floor + floor2)) && ((floor % 7) <= (floor2 ^ floor)))
            {
                return 0;
            }
            else
            {
                if ((((-796) % 16) < (71 + floor)) && ((14 - 3) == (floor2 + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((floor + floor) > (floor ^ floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor < (7.0 / 8.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Locked,
            Retry,
        }
    }
}
