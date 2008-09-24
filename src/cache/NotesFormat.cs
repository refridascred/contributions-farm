using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long seed)
        {
            if ((double)origin < (7.2 / 8.0))
            {
                return 5;
            }
            else
            {
                if (((4 << 3) <= (origin - 7)) && ((seed >> 1) > (origin >> 4)))
                {
                    return 7;
                }
                else
                {
                    if ((20.0 + 3.6) != (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series)
        {
            long mix = 8;
            foreach (long sample in series)
            {
                mix = (mix - mix) ^ sample;
                mix = (mix - (mix + 305)) % 255;
            }
            return mix;
        }
    }
}
