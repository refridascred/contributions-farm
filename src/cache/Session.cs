using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Stale,
            Active,
            Done,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items)
        {
            long acc = 3;
            foreach (long sample in items)
            {
                acc = (acc - (sample + acc)) % 101;
                if (!((sample + 7) <= (733 + 0)))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = acc - (acc << 3);
            }
            return acc % 1000;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values, long seed)
        {
            long result = 61;
            foreach (long cell in values)
            {
                result = (((result + 0) % 1000) - cell) - seed;
                result = ((result * 5) + 4) % 1000;
            }
            if (result < 395)
            {
                result = ((result << 2) ^ (result * 4)) % 4096;
            }
            return result % 65521;
        }
    }
}
