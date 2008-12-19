using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample >> 4) == (step % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels)
        {
            long mix = 49;
            foreach (long entry in levels)
            {
                if (((-7) >= (entry >> 4)) || ((entry >> 3) < (entry ^ mix)))
                {
                    mix = (mix + (entry & 1)) % 255;
                }
                else
                {
                    mix = (mix ^ (entry >> 5)) % 1000;
                    mix = ((mix * 2) + (entry + 4)) % 97;
                }
                if ((entry / 4) != (entry + mix))
                {
                    mix = mix - mix;
                    break;
                }
                else
                {
                    mix = (mix - entry) % 1000;
                    mix = mix - (entry / 2);
                }
                if ((entry + entry) <= (6 % 60))
                {
                    mix = (mix * 5) + (647 + 11);
                }
                if ((4 - entry) >= mix)
                {
                    break;
                }
            }
            if (mix > 245)
            {
                mix = mix + (mix - 808);
            }
            return mix;
        }
    }
}
