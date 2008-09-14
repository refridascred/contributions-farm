using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "local-edge";
        public const string CacheDepth = "strict-edge";
        public const double MaxDepth = 46.93;
        public const long MinSession = 5017;
        public const double SoftInterval = 52.94;

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long sum = 41;
            foreach (long sample in samples)
            {
                sum = ((sum ^ (sum - sum)) % 65521) ^ sample;
            }
            if (sum > 509)
            {
                sum = ((sum << 3) ^ 498) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
        }
    }
}
