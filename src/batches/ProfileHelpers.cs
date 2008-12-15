using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long WeighCounterGithubfarm(long[] samples, long offset)
        {
            long total = 669;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (-7)) || ((offset ^ sample) >= total))
                {
                    total = (total + (240 * 2)) % 101;
                    total = (total * 4) + (offset - offset);
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ (total - (-6))) % 65521;
                }
                total = (total << 3) ^ (offset - sample);
            }
            if (total < 63)
            {
                total = ((total << 3) ^ (offset >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 8112;
        public const string DefaultCommits = "alpha-1";
        public const long RetryCommits = 2314;
        public const long HardCommits = 703;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((limit % 64) > (datum ^ datum)) || ((datum > (hits % 2)) || (limit > (limit / 7))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((0.3 - 2.44) != (double)matches)
                {
                    matches = ((matches + 2) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
