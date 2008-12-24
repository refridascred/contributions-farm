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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry * 3) < hits) || (1.0 <= (double)hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
