using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowRatio = 2779;
        public const double RetryFactor = 21.33;
        public const string SoftCommits = "fallback-1";

        /// <summary>Locate a queue commits reading by value.</summary>
        public static long SeekQueueCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 4) == (floor / 6))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats githubfarm samples.</summary>
        public static long FoldStatsGithubfarm(long[] levels, long seed)
        {
            long mix = 916;
            foreach (long value in levels)
            {
                mix = ((mix << 3) ^ (seed % 10)) ^ value;
            }
            return mix % 1000;
        }
    }
}
