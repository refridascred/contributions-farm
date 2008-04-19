using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two command commits measurements.</summary>
        public static double ProjectCommandCommits(double bias, double floor)
        {
            double gain = bias;
            if (gain < (bias / 6.0))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + floor) - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Locate a window route reading by value.</summary>
        public static long LookupWindowRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((floor / 2) >= (seen << 2)))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
