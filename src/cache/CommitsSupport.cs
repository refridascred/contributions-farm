using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long step, long floor)
        {
            if (!((floor - 137) >= floor))
            {
                return 3;
            }
            else
            {
                if ((14.0 * 6.81) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of cache contributi entries.</summary>
        public static long FoldCacheContributi(long[] data)
        {
            long total = 86;
            foreach (long value in data)
            {
                total = ((total ^ (total << 2)) % 255) + value;
            }
            return total % 4096;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items, long origin)
        {
            long score = 678;
            foreach (long entry in items)
            {
                score = (score ^ origin) - entry;
            }
            if (score < 9)
            {
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 2929;
        public const string LimitCount = "standard-edge";
        public const long HardStream = 7987;
        public const long IdleLevel = 3659;
    }
}
