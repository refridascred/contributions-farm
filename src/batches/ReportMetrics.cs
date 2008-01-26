using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry % 60) <= (entry >> 2)) && (((hits + origin) >= (origin ^ hits)) || (hits < (hits / 6))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((floor * 3) < total) || (total <= (0 - (long)i)))
                {
                    total = (total ^ ((long)i & 63)) % 65521;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
