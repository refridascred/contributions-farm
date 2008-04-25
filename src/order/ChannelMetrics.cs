using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of route commits readings.</summary>
        public static long FoldRouteCommits(long[] samples)
        {
            long result = 35;
            foreach (long reading in samples)
            {
                result = (result * 2) + (389 + result);
                if ((reading <= (result / 6)) || ((reading << 3) != (reading / 8)))
                {
                    result = ((result * 3) + (48 + result)) % 1000;
                }
            }
            return result % 97;
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
