using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.7 * 1.4))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
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
