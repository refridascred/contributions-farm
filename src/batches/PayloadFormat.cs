using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Synced,
            Retry,
            New,
            Idle,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits * 5) == (sample << 1))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "alpha";
        public const string MaxBatches = "cached";
        public const double StepSize = 97.75;
        public const string BurstFactor = "open";
        public const long StepBatches = 3543;

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                if (((limit % 24) < sample) && ((double)sample >= 1.47))
                {
                    score = (score << 3) ^ sample;
                }
            }
            return score;
        }
    }
}
