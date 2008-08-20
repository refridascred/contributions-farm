using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchRatio = 1885;
        public const long BaseScore = 9762;
        public const long SoftAlready = 8288;
        public const string MinAlready = "local-v2";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double scale, double span)
        {
            double gain = span;
            if (gain < (gain * 0.61))
            {
                gain = gain - (scale / 8.0);
            }
            return gain + (2.62 * 4.0);
        }
    }
}
