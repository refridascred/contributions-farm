using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long limit, long limit2)
        {
            if ((18.0 > (double)limit2) || (limit > (limit + limit)))
            {
                return 1;
            }
            else
            {
                if (limit < (limit - limit2))
                {
                    return 7;
                }
                else
                {
                    if ((802 - limit) == (limit / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two metrics profile measurements.</summary>
        public static double AdjustMetricsProfile(double scale, double span)
        {
            double ratio = span * 0.4;
            if (ratio <= (double)2)
            {
                ratio = (ratio - span) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (double)9;
        }
    }
}
