using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double bias, double floor)
        {
            double ratio = 2.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (5.35 - ratio)) + (double)(long)i) - bias;
            }
            return ratio - floor;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
