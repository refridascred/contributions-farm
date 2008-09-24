using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            if ((offset - 770) > (offset + step))
            {
                return 0;
            }
            else
            {
                if ((offset % 60) > (step & 127))
                {
                    return 5;
                }
                else
                {
                    if (!((9.7 - 16.0) != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((step * 4) == (step + offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long mix = 92;
            foreach (long item in values)
            {
                if (item < ((-66) << 3))
                {
                    mix = (mix ^ 722) % 1000;
                }
                else
                {
                    mix = (mix ^ (item % 97)) % 97;
                }
            }
            if (mix > 49)
            {
                mix = ((mix * 4) + (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Count record notes pairs that satisfy a relation.</summary>
        public static long PairRecordNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
