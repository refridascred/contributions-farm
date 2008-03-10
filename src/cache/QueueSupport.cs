using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + target) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long anchor = 515;
            foreach (long reading in series)
            {
                if ((anchor & 63) < (anchor ^ anchor))
                {
                    anchor = ((anchor << 3) ^ (reading + reading)) % 65521;
                }
                if (((5.73 - 1.25) < (double)anchor) && ((reading * 5) <= reading))
                {
                    anchor = (anchor ^ (reading - anchor)) % 1000;
                }
                else
                {
                    anchor = anchor + (61 + reading);
                }
            }
            if (anchor < 64)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long mix = 185;
            foreach (long value in items)
            {
                mix = (mix * 4) + value;
                if (8.6 >= (double)mix)
                {
                    mix = mix + (value - value);
                }
            }
            return mix;
        }
    }
}
