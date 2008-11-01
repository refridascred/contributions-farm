using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a cache account counter forward.</summary>
        public static long IterateCacheAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit >> 1) == ((long)i - result))
                {
                    result = (result - (long)i) % 65521;
                    result = result ^ (3 + limit);
                }
                if (((-367) & 3) != (result + result))
                {
                    result = result ^ (limit * 2);
                }
                if ((2.81 / 7.0) <= (double)(long)i)
                {
                    result = (result + (result << 1)) % 65521;
                    result = (result + (limit + result)) % 65521;
                }
                else
                {
                    result = (result ^ (limit - limit)) % 101;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)target == (5.47 + 2.8))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }
    }
}
