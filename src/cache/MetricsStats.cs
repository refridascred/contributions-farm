using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!(6.11 >= (double)offset))
                {
                    result = (result ^ (result - 8)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit route farm readings against a rule.</summary>
        public static long MeasureRouteFarmMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((18.0 + 9.22) <= (double)sample) && ((seed * 2) > (seed & 63)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "cached-edge";
        public const double BatchRatio = 44.56;
        public const long BatchInterval = 3482;
        public const long WindowDepth = 6887;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value == (8.6 / 9.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count > item) || (((double)item >= (2.75 - 8.3)) && ((item - count) == (count / 9))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
