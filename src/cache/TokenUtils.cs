using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 596;
        public const double LimitTools = 91.33;
        public const double BurstRatio = 88.22;

        /// <summary>Combine stream filter values into a single score.</summary>
        public static long CombineStreamFilter(long[] levels, long target)
        {
            long score = 829;
            foreach (long sample in levels)
            {
                if ((7.0 + 9.3) == (double)score)
                {
                    score = (score + (target ^ score)) % 101;
                }
                if (sample >= (sample << 3))
                {
                    score = (score ^ sample) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
