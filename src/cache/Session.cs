using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 2185;
        public const long BatchBudget = 5507;
        public const long HardQueue = 4562;
        public const string MaxBudget = "legacy-v2";
        public const long MaxQueue = 7519;

        /// <summary>Compare every pair of buffer contributi readings.</summary>
        public static long CompareBufferContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
