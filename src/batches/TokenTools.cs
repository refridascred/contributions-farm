using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix << 2) ^ offset;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)anchor >= (0.6 + 1.73)))
                {
                    anchor = anchor ^ (anchor << 3);
                }
                anchor = (anchor ^ (anchor + anchor)) % 4096;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + (long)i) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of layout contributi entries.</summary>
        public static long WeighLayoutContributi(long[] series)
        {
            long score = 77;
            foreach (long item in series)
            {
                if ((double)501 == (double)item)
                {
                    score = ((score * 4) + (item + score)) % 255;
                }
            }
            return score % 4096;
        }
    }
}
