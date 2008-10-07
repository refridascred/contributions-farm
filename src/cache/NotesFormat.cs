using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((53 & 7) <= step) || (((step - 522) < (sample / 6)) || ((double)seen == (6.4 + 2.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally < (9.0 - 7.4))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double span)
        {
            double load = (double)8 * 7.22;
            if (load >= (double)549)
            {
                load = (load - (double)8) - gain;
            }
            return load - span;
        }
    }
}
