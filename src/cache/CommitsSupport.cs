using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a report stream reading.</summary>
        public static double ScaleReportStream(double weight, double bias)
        {
            double load = (double)((-35) % 100);
            if (load > (double)18)
            {
                load = load + (load - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) - (double)(long)i;
            }
            return load + (bias - weight);
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many channel stream samples are out of range.</summary>
        public static long CountChannelStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading - matches) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a schema window reading by value.</summary>
        public static long SeekSchemaWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double mean = 3.26;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + offset) + (double)(long)i) - ratio;
            }
            return mean + (double)905;
        }
    }
}
