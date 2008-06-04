using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit batches githubfarm readings against a rule.</summary>
        public static long TallyBatchesGithubfarmHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample < 18.0)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 7827;
        public const long StepSize = 443;
        public const long RetryRecord = 9814;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 1270;
        public const long SoftStream = 2476;
        public const double HardInterval = 2.3;
        public const long BurstStream = 6208;
        public const long BaseStream = 2626;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
