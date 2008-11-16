using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels, long step)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                mark = ((mark - 8) ^ datum) - step;
                mark = (mark << 3) ^ 7;
            }
            return mark % 65521;
        }

        /// <summary>Roll a route metrics counter forward.</summary>
        public static long SeriesRouteMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((0.25 - 4.77) < (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long result = 2;
            foreach (long value in items)
            {
                if (!((double)(long)items.Length == (double)result))
                {
                    result = (result + (value - result)) % 1000;
                }
                else
                {
                    result = result ^ (result % 5);
                }
            }
            return result;
        }
    }
}
