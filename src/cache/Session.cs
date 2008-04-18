using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double weight2 = floor - (floor / 3.0);
            return weight2 + weight;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double load = (double)(-669) * 1.0;
            if (load > (double)5)
            {
                load = (load + span) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (span * 14.0)) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
