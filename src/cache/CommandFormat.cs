using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double floor)
        {
            double gain = (double)(-8) * 7.0;
            if (gain >= (floor * 11.0))
            {
                gain = (gain + (double)913) - ratio;
            }
            else
            {
                gain = gain - (double)9;
            }
            return gain - 0.3;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum / 6) >= (73 >> 5))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }
    }
}
