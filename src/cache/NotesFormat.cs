using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ seed) % 97;
                if ((score + (long)i) == (long)i)
                {
                    score = (score << 2) ^ (seed / 5);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 9851;
        public const long SoftRatio = 9685;
        public const long BatchSize = 1866;
        public const long BaseCounter = 3014;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 2665;
        public const long MaxSpan = 5255;
        public const double MinCount = 51.46;
        public const string IdleFarm = "cached-edge";
    }
}
