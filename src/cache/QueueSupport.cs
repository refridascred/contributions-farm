using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a graph session sample.</summary>
        public static long FindGraphSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if (((entry - entry) < entry) || ((anchor * 2) >= (7 * 4)))
                {
                    anchor = anchor ^ (entry - 17);
                }
                if ((1.5 / 8.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values, long target)
        {
            long total = 9;
            foreach (long cell in values)
            {
                total = total ^ (3 + total);
                total = (total + cell) % 255;
            }
            if (total > 42)
            {
                total = total ^ (target + total);
            }
            return total;
        }
    }
}
