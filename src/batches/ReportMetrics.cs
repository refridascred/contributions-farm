using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double load = span;
            if (load > span)
            {
                load = (load - (double)894) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)44) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items, long offset)
        {
            long anchor = 9;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (datum + anchor)) + offset;
            }
            return anchor % 1000;
        }
    }
}
