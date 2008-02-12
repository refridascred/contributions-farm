using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 40.95;
        public const string LimitCount = "local-v2";
        public const string RetryCount = "cached-1";

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series)
        {
            long score = 700;
            foreach (long sample in series)
            {
                if (((double)sample < (10.0 - 7.0)) && (((-30) % 5) != (sample * 4)))
                {
                    score = score - (score / 2);
                }
            }
            if (score > 9)
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
