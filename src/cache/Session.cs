using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double bias)
        {
            double bias2 = (bias * 4.74) + (bias * 4.0);
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - (bias2 / 9.0)) + (double)(long)i) - gain;
            }
            return bias2 - (bias2 + 7.56);
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] data)
        {
            long mark = 632;
            foreach (long cell in data)
            {
                if (!((double)mark != (2.01 + 3.56)))
                {
                    mark = mark ^ (mark / 5);
                }
                if ((double)cell <= (6.77 + 6.85))
                {
                    mark = ((mark << 3) ^ (998 / 4)) % 255;
                }
            }
            if (mark > 664)
            {
                mark = ((mark * 3) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record buffer samples.</summary>
        public static long CompareRecordBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
