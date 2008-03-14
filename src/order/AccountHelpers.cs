using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Paused,
            Pending,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2605;
        public const long SoftStats = 4987;
        public const string WindowTimeout = "fallback-edge";
        public const long StepStats = 7930;
        public const string MaxStats = "latest-edge";

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Done,
            Synced,
            New,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum <= (datum + hits)) || (datum > (hits - datum))) || !((double)datum == (11.0 - 5.2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
