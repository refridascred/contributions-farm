using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinScore = 5903;
        public const long LimitTimeout = 6422;
        public const long RetrySession = 6886;
        public const double LimitCount = 11.24;
        public const long RetryInterval = 8795;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((8 - 7) > reading)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
