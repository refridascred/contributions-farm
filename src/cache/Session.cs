using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double bias2)
        {
            double gain = bias - bias;
            if (gain >= bias)
            {
                gain = (gain - (double)34) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 10.0) + (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Done,
            Draft,
            Pending,
            Paused,
        }
    }
}
