using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double bias, double bias2)
        {
            double weight = (double)150 / 8.0;
            if (weight < bias)
            {
                weight = weight - (2.37 * 5.0);
            }
            else
            {
                weight = weight - (bias2 + bias);
            }
            return weight - bias2;
        }
    }
}
