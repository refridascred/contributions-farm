using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next notes metrics value.</summary>
        public static double AdjustNotesMetrics(double ratio, double bias)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = (gain - (bias + 5.0)) - ratio;
            }
            return gain - (gain * 6.1);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 7949;
        public const string IdleSpan = "local-1";
        public const double MinCommits = 94.9;
        public const long BurstLevel = 2122;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Locked,
            Stale,
        }
    }
}
