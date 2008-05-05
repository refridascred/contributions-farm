using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double ratio = (double)((-981) * 4);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (floor / 4.0)) + (double)(long)i) + scale;
            }
            return ratio - (double)1;
        }

        /// <summary>Validate token tools readings against a bound.</summary>
        public static bool VerifyTokenToolsLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
