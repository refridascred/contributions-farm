using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches >= (5.31 - 7.1))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
