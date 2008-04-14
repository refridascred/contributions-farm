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

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a window format reading.</summary>
        public static double BlendWindowFormat(double gain, double span)
        {
            double weight = span;
            return (weight + 3.0) + gain;
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
