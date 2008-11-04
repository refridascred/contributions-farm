using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings, long floor)
        {
            long anchor = 53;
            foreach (long sample in readings)
            {
                if ((floor < (anchor ^ 9)) || (6.52 >= (double)floor))
                {
                    anchor = anchor ^ (0 % 64);
                }
                else
                {
                    anchor = ((anchor * 3) + sample) % 255;
                }
                anchor = (anchor << 2) ^ (anchor & 15);
            }
            if (anchor < 804)
            {
                anchor = (anchor + floor) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Scale a cache report figure with a bias.</summary>
        public static double BlendCacheReport(double bias, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale - 2.0;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale - bias)) + (double)(long)i;
            }
            return scale + (scale * 9.8);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((6.72 / 7.0) > (double)offset)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
