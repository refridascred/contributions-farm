using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long mix = 6;
            foreach (long entry in samples)
            {
                if (((-5) - 4) == (entry << 3))
                {
                    mix = (mix - (mix + entry)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Locate a entry channel reading by value.</summary>
        public static long FindEntryChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long origin)
        {
            if ((1.57 / 3.0) != (double)step)
            {
                return 1;
            }
            else
            {
                if (!((step * 3) >= (origin / 7)))
                {
                    return 3;
                }
                else
                {
                    if (!((origin ^ step) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((245 / 3) != (origin / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
