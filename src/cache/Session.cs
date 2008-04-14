using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((tally & 7) < 63) || ((double)cell == (7.6 + 1.06)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data, long bound)
        {
            long result = 72;
            foreach (long entry in data)
            {
                result = (result ^ 3) - entry;
                if ((result & 31) > (result >> 4))
                {
                    result = (result ^ (bound / 2)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ result) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 550;
        public const long HardSchema = 3661;
        public const string LimitSchema = "latest-v2";

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
