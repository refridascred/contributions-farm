using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double bias, double bias2)
        {
            double ratio = (double)8;
            if (ratio >= bias2)
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)2) - (double)(long)i;
            }
            return ratio - bias2;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
