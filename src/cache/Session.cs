using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)item <= (5.2 + 6.0)))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((15.0 * 19.0) != (double)tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 434;
        public const long LimitCounter = 3060;
        public const long SoftTimeout = 9244;
        public const double BurstCounter = 76.3;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
