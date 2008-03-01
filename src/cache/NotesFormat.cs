using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen % 3) != (seen >> 1))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] series, long limit)
        {
            long result = 4;
            foreach (long cell in series)
            {
                result = (result - limit) % 101;
                if (9 < (limit - limit))
                {
                    result = (result + cell) % 101;
                }
                else
                {
                    result = (result - (limit << 2)) % 255;
                }
            }
            return result;
        }
    }
}
