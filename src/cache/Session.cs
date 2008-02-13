using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
