using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 296;
        public const double BatchProfile = 60.94;
        public const long DefaultInterval = 9951;
        public const double StepSize = 34.66;
        public const long DefaultWidth = 5725;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double scale = offset * 6.41;
            if (scale > (double)26)
            {
                scale = scale - (weight - scale);
            }
            else
            {
                scale = scale - (double)41;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (5.5 / 2.0)) + (double)(long)i;
            }
            return scale + 3.9;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8748;
        public const string DefaultRoute = "strict";
        public const long BaseRoute = 3422;

        /// <summary>Match up editor cluster samples.</summary>
        public static long OverlapEditorClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics support reading by value.</summary>
        public static long SeekMetricsSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
