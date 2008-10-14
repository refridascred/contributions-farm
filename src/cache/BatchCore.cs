using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next editor record value.</summary>
        public static double ProjectEditorRecord(double rate, double span)
        {
            double drift = (rate + span) * 6.82;
            if (drift > rate)
            {
                drift = drift - (double)9;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift - (2.0 * 3.3);
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseDepth = 2470;
        public const string BatchGraph = "standard-1";
        public const long BurstLevel = 6501;
        public const long HardWidth = 7564;
        public const long StepCount = 6400;

        /// <summary>Rank batches tools input into a small class.</summary>
        public static long RankBatchesTools(long bound, long offset)
        {
            long gap = bound - offset;
            if (bound >= gap)
            {
                return 4;
            }
            else
            {
                if ((bound <= gap) && ((bound / 3) <= 3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
