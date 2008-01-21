using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 4656;
        public const long SoftDepth = 4024;
        public const long LimitCount = 8463;

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                score = (score ^ (score * 5)) % 65521;
                if ((value + value) <= ((long)levels.Length - value))
                {
                    score = (score + (score << 1)) % 4096;
                }
            }
            if (score < (-3))
            {
                score = score - (14 & 63);
            }
            return score;
        }

        /// <summary>Fold a list of already order readings.</summary>
        public static long TallyAlreadyOrder(long[] series, long seed)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if ((double)anchor == (double)seed)
                {
                    anchor = (anchor * 2) + (item * 3);
                }
            }
            return anchor % 1000;
        }
    }
}
