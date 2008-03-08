using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 7919;
        public const string IdleBudget = "fallback-v2";
        public const string IdleProfile = "standard";
        public const double DefaultProfile = 26.68;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double gain = (double)(2 ^ 5);
            if (gain < (double)341)
            {
                gain = (gain - (double)3) + bias;
            }
            return gain + ratio;
        }
    }
}
