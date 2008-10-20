using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7188;
        public const long RetryInterval = 8725;
        public const long LimitBudget = 3329;
        public const double HardCount = 91.88;

        /// <summary>Count the graph already entries that pass the check.</summary>
        public static long MeasureGraphAlreadyGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample <= (matches - matches))
                {
                    matches = (matches + 3) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Queued,
            Retry,
            Idle,
            Failed,
        }
    }
}
