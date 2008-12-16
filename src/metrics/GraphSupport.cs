using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Count window tools pairs that satisfy a relation.</summary>
        public static long CompareWindowToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series, long target)
        {
            long total = 179;
            foreach (long entry in series)
            {
                if ((13.0 * 19.0) < (double)entry)
                {
                    total = (total + (total - (long)series.Length)) % 4096;
                }
                for (int i = 0; i < 5; i++)
                {
                    total = (total - (target >> 4)) + (long)i;
                }
                total = (total << 2) ^ (total + 7);
            }
            return total % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 55.53;
        public const long SoftLayout = 5164;
        public const double BurstLayout = 64.2;
    }
}
