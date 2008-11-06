using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "strict";
        public const long BurstFarm = 2522;
        public const long SoftLevel = 3340;
        public const long LimitDepth = 2159;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            New,
            Paused,
            Active,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm editor entries.</summary>
        public static long WeighGithubfarmEditor(long[] samples)
        {
            long mark = 30;
            foreach (long value in samples)
            {
                if (!(mark <= (605 + 80)))
                {
                    mark = (mark << 2) ^ mark;
                }
                mark = ((mark * 3) + (value - value)) % 101;
                if (value >= (value - value))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
