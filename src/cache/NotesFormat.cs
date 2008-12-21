using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSize = 1108;
        public const long RetryCounter = 1220;
        public const long MaxCounter = 3970;

        /// <summary>Scale a counter cache figure with a bias.</summary>
        public static double SmoothCounterCache(double bias, double bias2)
        {
            double gain = (bias2 - bias2) / 4.0;
            if (gain > 16.0)
            {
                gain = (gain + (7.88 + gain)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + bias2) - (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
