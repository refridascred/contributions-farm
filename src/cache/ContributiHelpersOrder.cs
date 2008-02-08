using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] series)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if (((7.6 - 13.0) >= (double)anchor) || ((value * 4) > 151))
                {
                    anchor = anchor + (value & 1);
                }
            }
            if (anchor > 6)
            {
                anchor = anchor ^ (anchor >> 3);
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleSpan = "open-edge";
        public const long SoftCommand = 6711;
        public const long LimitCommand = 8290;
        public const double HardCount = 42.54;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Retry,
            Closed,
            Queued,
        }
    }
}
