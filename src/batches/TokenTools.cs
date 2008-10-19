using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double load = bias - bias;
            if (load > load)
            {
                load = load - (bias - scale);
            }
            else
            {
                load = load + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (bias * 3.0)) + (double)(long)i;
            }
            return load + (bias - bias);
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Active,
            Paused,
            Retry,
            Queued,
        }
    }
}
