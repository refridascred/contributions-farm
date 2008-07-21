using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine filter metrics values into a single score.</summary>
        public static long FoldFilterMetrics(long[] series, long target)
        {
            long anchor = 9;
            foreach (long value in series)
            {
                anchor = ((anchor << 2) ^ (anchor - value)) + target;
            }
            return anchor % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4.4 < (double)sample)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (2 <= count)
                {
                    count = ((count + 3) + datum) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
