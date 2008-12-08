using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc + limit) % 65521) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
