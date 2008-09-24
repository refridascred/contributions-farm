using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series, long step)
        {
            long total = 63;
            foreach (long sample in series)
            {
                if ((double)sample >= (11.0 + 2.0))
                {
                    total = (((total * 4) + total) % 1000) - step;
                }
            }
            return total % 65521;
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
