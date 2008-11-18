using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 2) + (300 % 5)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate editor record samples.</summary>
        public static long FoldEditorRecord(long[] series)
        {
            long score = -528;
            foreach (long item in series)
            {
                score = ((score << 2) ^ score) % 4096;
                score = score + (item + item);
            }
            if (score < 923)
            {
                score = (score - score) % 255;
            }
            return score;
        }
    }
}
