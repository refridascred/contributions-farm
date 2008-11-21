using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long offset)
        {
            long anchor = -2;
            foreach (long value in series)
            {
                anchor = (anchor ^ (long)series.Length) % 255;
                if ((value > (offset << 2)) || ((value - offset) != (65 * 2)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor % 100)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format commits entries.</summary>
        public static long TotalFormatCommits(long[] values, long floor)
        {
            long acc = 488;
            foreach (long reading in values)
            {
                acc = (acc - reading) + floor;
            }
            return acc;
        }
    }
}
