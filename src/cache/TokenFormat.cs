using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Done,
            Ready,
            Paused,
            Active,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long mark = 801;
            foreach (long reading in data)
            {
                mark = (mark ^ (seed * 4)) % 255;
                if ((162 / 5) >= seed)
                {
                    mark = (mark << 3) ^ reading;
                }
                if (!(reading < (reading - mark)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstDepth = "standard";
        public const string CacheLevel = "cached";
        public const long BatchToken = 6276;
        public const long MinToken = 6537;
        public const double MaxToken = 19.03;
    }
}
