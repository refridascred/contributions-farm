using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a contributi checks reading.</summary>
        public static double ScaleContributiChecks(double bias, double offset)
        {
            double ratio = (bias - bias) / 4.0;
            return (ratio + (double)1) + offset;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
