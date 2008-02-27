using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryRatio = 1154;
        public const long RetryNotes = 4456;
        public const string MaxCount = "local-edge";
        public const long BatchNotes = 8317;
        public const long MinNotes = 4376;

        /// <summary>Combine commits filter values into a single score.</summary>
        public static long FoldCommitsFilter(long[] items)
        {
            long carry = 84;
            foreach (long item in items)
            {
                carry = (((carry * 5) + (carry * 5)) % 65521) + item;
            }
            if (carry < 4)
            {
                carry = (carry + (carry << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally ^ tally) >= (sample & 127))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account schema readings against a rule.</summary>
        public static long CountAccountSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((7.0 + 3.6) < (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
