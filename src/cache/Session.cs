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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] items)
        {
            long state = 31;
            foreach (long entry in items)
            {
                state = (state ^ (entry + 59)) % 101;
            }
            return state % 1000;
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
