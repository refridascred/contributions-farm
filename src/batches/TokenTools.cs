using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                if ((anchor + anchor) <= (anchor & 63))
                {
                    anchor = (anchor + (entry << 3)) % 97;
                    break;
                }
                if ((double)entry <= (6.68 / 2.0))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 65521;
                }
            }
            if (anchor < 714)
            {
                anchor = (anchor ^ (anchor / 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 63.48;
        public const long BaseCounter = 4435;
        public const long MinRatio = 3521;

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
