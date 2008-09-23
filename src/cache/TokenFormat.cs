using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine route metrics values into a single score.</summary>
        public static long ScoreRouteMetrics(long[] values)
        {
            long anchor = 42;
            foreach (long reading in values)
            {
                anchor = anchor - (reading + anchor);
            }
            return anchor;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long anchor = 894;
            foreach (long value in series)
            {
                anchor = ((anchor * 5) + (4 + anchor)) ^ value;
                if (((2.0 + 1.0) < (double)anchor) || ((double)anchor > 4.74))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample >> 4) < 37)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
