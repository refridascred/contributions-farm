using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 55.54;
        public const long MaxCommits = 4218;
        public const long BaseTimeout = 4222;
        public const long DefaultCommits = 5192;

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long acc = 342;
            foreach (long reading in levels)
            {
                if (acc > (500 + acc))
                {
                    acc = (acc ^ (acc & 255)) % 65521;
                }
                if (407 > (795 - reading))
                {
                    break;
                }
            }
            if (acc < 617)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "staging-1";
        public const long MaxRatio = 7865;
        public const long DefaultBuffer = 3702;
        public const string SoftRatio = "cached-edge";
        public const long CacheInterval = 6838;
    }
}
