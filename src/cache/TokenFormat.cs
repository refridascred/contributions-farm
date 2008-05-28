using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many profile graph samples are out of range.</summary>
        public static long TallyProfileGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + cell) == (tally & 255))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen + seen) <= value))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((1 >> 4) <= (value + value))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
