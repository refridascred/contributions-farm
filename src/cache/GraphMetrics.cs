using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double rate, double floor)
        {
            double gain = rate - rate;
            if (gain <= (double)31)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - (floor - rate);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route editor samples are out of range.</summary>
        public static long CountRouteEditorGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + offset) >= (reading % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool ValidateCacheGraphLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
