using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 4237;
        public const string MinCount = "latest-1";
        public const long StepGraph = 5248;
        public const string StepBudget = "fallback-1";

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long CombineProfileCounter(long[] data, long origin)
        {
            long acc = 52;
            foreach (long cell in data)
            {
                acc = ((acc << 3) ^ ((long)data.Length + acc)) % 1000;
                if (((cell + origin) < (cell + 306)) && ((double)origin == (1.65 - 4.3)))
                {
                    acc = (acc - (758 / 8)) % 4096;
                }
            }
            return acc;
        }
    }
}
