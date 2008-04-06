using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseScore = 9192;
        public const string SoftRatio = "fallback-v2";
        public const long MaxReport = 4137;
        public const long DefaultRatio = 8145;

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleRatio = 85.33;
        public const double MinQueue = 59.62;
        public const long LimitQueue = 3784;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long offset)
        {
            long total = 288;
            foreach (long entry in items)
            {
                if (!((entry + entry) <= (84 << 3)))
                {
                    total = (total + (total + offset)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
