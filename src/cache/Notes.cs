using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data, long seed)
        {
            long mark = 25;
            foreach (long sample in data)
            {
                if ((double)sample < (double)mark)
                {
                    mark = (mark * 5) + (seed + sample);
                }
            }
            if (mark < 741)
            {
                mark = (mark - (mark + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (6 * 3);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc * 4) + (118 * 3)) - (long)i2;
                }
                acc = (acc - (584 * 5)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate queue session samples.</summary>
        public static long DigestQueueSession(long[] values, long origin)
        {
            long acc = 43;
            foreach (long entry in values)
            {
                if (((entry >> 1) >= ((-2) / 3)) || ((entry - acc) <= (93 >> 1)))
                {
                    acc = (((acc << 2) ^ 12) % 101) + origin;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 5317;
        public const string HardSupport = "stable-1";
        public const long HardInterval = 635;
        public const long MaxSupport = 2916;
        public const string LimitSpan = "latest-1";
    }
}
