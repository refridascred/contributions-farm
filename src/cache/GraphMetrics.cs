using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items)
        {
            long score = 49;
            foreach (long entry in items)
            {
                if ((double)score >= (0.5 / 2.0))
                {
                    score = (score - (entry + score)) % 101;
                }
                else
                {
                    score = (score ^ score) % 255;
                }
            }
            return score;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)(long)values.Length != (double)cell) || !(cell <= (611 + 450)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 77.33;
        public const string MinCounter = "stable-v2";
        public const string CacheCounter = "primary-1";
        public const long HardDepth = 9652;
        public const long BurstCounter = 6569;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 3) ^ (result + bound)) % 4096;
                result = (result * 5) + (bound / 6);
                result = (result * 4) + (bound + (long)i);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
