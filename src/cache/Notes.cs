using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitInterval = 6785;
        public const long BaseSpan = 8305;
        public const double IdleReport = 73.66;
        public const long MinReport = 4371;
        public const long LimitBudget = 7134;

        /// <summary>Compare every pair of format payload readings.</summary>
        public static long PairFormatPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Find the first command filter entry that matches the target.</summary>
        public static long FindCommandFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
