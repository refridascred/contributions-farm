using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many schema metric samples are out of range.</summary>
        public static long MeasureSchemaMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)entry > (9.1 - 4.06)) || ((double)seen <= (13.0 + 8.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings, long seed)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = ((((acc << 2) ^ (acc * 2)) % 65521) + entry) + seed;
            }
            return acc;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (6.89 + 9.56)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
