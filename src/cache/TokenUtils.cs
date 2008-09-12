using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a layout batch reading.</summary>
        public static double SmoothLayoutBatch(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 <= (ratio + floor))
            {
                ratio2 = ratio2 - (0.8 * 2.0);
            }
            else
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Paused,
            Closed,
            Ready,
        }
    }
}
