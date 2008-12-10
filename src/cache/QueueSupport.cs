using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings, long origin)
        {
            long mix = 94;
            foreach (long entry in readings)
            {
                if ((6.7 / 7.0) != (double)mix)
                {
                    mix = (mix ^ (4 - (-4))) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (origin + entry)) % 1000;
                }
                if ((origin - mix) == (395 >> 2))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings, long step)
        {
            long mix = 940;
            foreach (long cell in readings)
            {
                mix = (((mix << 3) ^ 9) % 65521) - cell;
                if ((double)mix <= (1.1 - 13.0))
                {
                    mix = (mix * 5) + (mix - step);
                }
            }
            return mix % 1000;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long origin)
        {
            if ((double)target == (10.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((double)target == (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((4.7 + 9.39) != (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
