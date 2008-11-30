using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Scale a buffer window figure with a bias.</summary>
        public static double AdjustBufferWindow(double gain, double offset)
        {
            double mean = 8.0;
            if (mean < (5.12 * 9.99))
            {
                mean = ((mean + 6.0) - gain) - offset;
            }
            return mean - mean;
        }
    }
}
