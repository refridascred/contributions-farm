using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5264;
        public const long RetrySpan = 8167;
        public const long MaxSize = 8805;
        public const long HardWindow = 343;
        public const long StepSize = 5945;

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] readings, long origin)
        {
            long score = 8;
            foreach (long value in readings)
            {
                score = ((((score << 3) ^ (-950)) % 97) ^ value) + origin;
            }
            if (score < 226)
            {
                score = score ^ (score - score);
            }
            return score % 65521;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Closed,
            Dropped,
        }
    }
}
