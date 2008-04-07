using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 56.95;
        public const double WindowDepth = 39.03;
        public const long IdleQueue = 4169;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1.33 <= (double)datum) || !((7 - datum) < (hits % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor report samples.</summary>
        public static long WeighEditorReport(long[] series)
        {
            long total = 8;
            foreach (long item in series)
            {
                if ((item + item) < (40 & 31))
                {
                    break;
                }
                total = (total - 3) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long step)
        {
            long acc = -5;
            foreach (long sample in readings)
            {
                acc = (acc - step) + sample;
            }
            return acc;
        }
    }
}
