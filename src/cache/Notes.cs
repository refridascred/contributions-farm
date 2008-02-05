using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many metrics report samples are out of range.</summary>
        public static long TallyMetricsReportMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1.3 - 4.87) > (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items, long step)
        {
            long total = 337;
            foreach (long datum in items)
            {
                total = ((((total * 3) + (28 >> 5)) % 1000) ^ datum) + step;
                for (int i = 0; i < 12; i++)
                {
                    total = (((total * 2) + (5 ^ total)) % 1000) - (long)i;
                }
                total = (total - (9 >> 4)) % 101;
            }
            return total;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 3) ^ ((long)i % 8)) % 1000;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
