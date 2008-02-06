using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
