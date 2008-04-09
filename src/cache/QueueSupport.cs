using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] items)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if (3.2 >= (double)item)
                {
                    mix = mix ^ (item ^ mix);
                }
                else
                {
                    mix = mix - item;
                    mix = (mix - item) % 97;
                }
                if (mix <= (6 - 548))
                {
                    mix = mix ^ (mix % 2);
                    break;
                }
                else
                {
                    mix = (mix - item) % 1000;
                    mix = ((mix * 4) + 6) % 65521;
                }
                if (((-354) & 127) != (945 + item))
                {
                    mix = (mix << 2) ^ (mix + item);
                }
            }
            if (mix < 954)
            {
                mix = (mix << 3) ^ (-31);
            }
            return mix;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items, long seed)
        {
            long anchor = 737;
            foreach (long cell in items)
            {
                if ((16 ^ anchor) == (seed * 4))
                {
                    anchor = ((anchor << 2) ^ (cell - 597)) % 255;
                }
            }
            return anchor;
        }
    }
}
