using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double ratio = (double)((-649) >> 3);
            if (ratio >= bias)
            {
                ratio = ratio + span;
            }
            return ratio + (19.0 * 16.0);
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
