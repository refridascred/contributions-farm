using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double gain = (span / 8.0) * 16.0;
            if (gain > span)
            {
                gain = (gain - (double)45) - scale;
            }
            return gain + span;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}
