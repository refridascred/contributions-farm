using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "fallback-1";
        public const double LimitFactor = 9.52;
        public const double StepAccount = 5.56;
        public const long CacheAccount = 6622;
        public const string IdleDepth = "staging-edge";

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
