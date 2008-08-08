using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 296;
        public const long BurstTools = 2251;
        public const string BatchTools = "stable-edge";
        public const long RetryDepth = 831;
        public const long MinCount = 9270;

        /// <summary>Find the first commits format entry that matches the target.</summary>
        public static long FindCommitsFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= 8.02)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches & 7) == ((-801) / 7))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ count) != (664 - count))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
