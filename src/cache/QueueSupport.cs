using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((2.0 + 4.2) >= (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
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
