using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftInterval = 3973;
        public const double RetryBatches = 82.13;
        public const double DefaultBatches = 81.06;
        public const double StepCount = 92.66;

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
