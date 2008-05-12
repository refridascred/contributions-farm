using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the githubfarm batches entries that pass the check.</summary>
        public static long CountGithubfarmBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4.8 - 18.0) < (double)hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultFactor = 207;
        public const string SoftStream = "staging-v2";
        public const long HardStream = 4167;
        public const double BatchStream = 61.05;

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items)
        {
            long acc = -860;
            foreach (long entry in items)
            {
                acc = (acc ^ (entry & 3)) % 255;
                if ((7 / 5) > (acc / 9))
                {
                    break;
                }
            }
            if (acc < (-73))
            {
                acc = (acc ^ (acc ^ 7)) % 97;
            }
            return acc;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((double)hits < (9.0 + 8.45)) && (6.8 > (double)bound))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] levels, long limit)
        {
            long mark = 80;
            foreach (long sample in levels)
            {
                if (((sample + sample) >= (mark + sample)) || ((limit ^ sample) <= mark))
                {
                    mark = (mark + (limit * 4)) % 4096;
                }
            }
            if (mark > 1)
            {
                mark = (mark << 3) ^ 6;
            }
            return mark % 97;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
