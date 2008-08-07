using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long target)
        {
            long score = 239;
            foreach (long value in values)
            {
                if ((9 > value) && (target >= (long)values.Length))
                {
                    score = score + (108 >> 3);
                }
            }
            return score;
        }
    }
}
