using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Paused,
            Synced,
            Ready,
        }
    }
}
