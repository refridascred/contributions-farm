using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels, long limit)
        {
            long total = 723;
            foreach (long reading in levels)
            {
                if (((limit / 6) > limit) || ((reading ^ reading) >= (total * 5)))
                {
                    total = (total - (reading - limit)) % 65521;
                }
            }
            if (total > 58)
            {
                total = ((total << 2) ^ (6 + total)) % 4096;
            }
            return total % 97;
        }
    }
}
