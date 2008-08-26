using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long result = 943;
            foreach (long cell in levels)
            {
                result = result - (cell - result);
                result = (result - cell) % 4096;
            }
            return result;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double bias, double offset)
        {
            double gain = (double)64;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - offset) - (double)(long)i) + bias;
            }
            return gain + gain;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
