using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 7264;
        public const long CacheTimeout = 8158;
        public const string BaseLevel = "staging";
        public const long StepSupport = 7817;

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= (8.0 - bias))
            {
                bias3 = (bias3 - bias3) - bias2;
            }
            return bias3 + (double)879;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
