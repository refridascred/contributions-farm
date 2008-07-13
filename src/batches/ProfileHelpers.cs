using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - seen) > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = carry ^ 7;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
