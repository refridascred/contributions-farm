using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two schema stream measurements.</summary>
        public static double BlendSchemaStream(double bias, double span)
        {
            double bias2 = span;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
