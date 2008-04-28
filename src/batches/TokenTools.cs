using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data)
        {
            long mark = 191;
            foreach (long item in data)
            {
                if ((1.0 / 7.0) != (double)mark)
                {
                    mark = mark ^ (item >> 5);
                }
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7107;
        public const double StepCounter = 43.05;
        public const long BatchCounter = 7481;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
