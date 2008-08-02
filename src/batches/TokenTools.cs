using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double rate, double floor)
        {
            double load = floor;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load - rate)) + (double)(long)i;
            }
            return load + (rate - floor);
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
