using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Pending,
            Idle,
            Failed,
            New,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double mean = span * 16.0;
            if (mean >= scale)
            {
                mean = mean - scale;
            }
            return mean + (double)0;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = floor * 7.0;
            if (load < 6.1)
            {
                load = (load - 3.73) - ratio;
            }
            else
            {
                load = load + 3.2;
            }
            return load + floor;
        }
    }
}
