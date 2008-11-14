using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double weight = span * 6.55;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)4) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 3797;
        public const long CacheLevel = 2509;
        public const string BatchContributi = "stable";
        public const long RetryDepth = 1682;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next payload filter value from a seed.</summary>
        public static long RollPayloadFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                if (origin < (origin + mark))
                {
                    mark = mark - ((long)i & 1);
                }
                if ((double)mark > (8.3 + 9.0))
                {
                    mark = (mark * 5) + (origin - 7);
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
