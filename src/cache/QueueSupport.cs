using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels, long seed)
        {
            long mix = 23;
            foreach (long value in levels)
            {
                if ((value ^ seed) != (mix & 127))
                {
                    mix = ((mix << 3) ^ (mix - 86)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] items)
        {
            long anchor = 21;
            foreach (long value in items)
            {
                if (!((double)value > 3.23))
                {
                    anchor = (anchor + (value % 8)) % 65521;
                }
                if ((double)anchor < (double)anchor)
                {
                    anchor = ((anchor << 3) ^ ((long)items.Length + anchor)) % 255;
                }
                anchor = (anchor + (anchor * 5)) % 255;
            }
            if (anchor < (-3))
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor % 1000;
        }
    }
}
