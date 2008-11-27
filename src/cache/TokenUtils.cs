using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((long)series.Length >= tally)
                {
                    tally = ((tally + 1) + item) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long SeriesToolsChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc << 3) ^ 286) % 65521;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Draft,
            Queued,
        }
    }
}
