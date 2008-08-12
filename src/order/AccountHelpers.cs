using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "local-edge";
        public const long DefaultWidth = 7834;
        public const double CacheGraph = 62.04;
        public const long IdleGraph = 9812;

        /// <summary>Measure how many buffer tools samples are out of range.</summary>
        public static long MeasureBufferToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((seen / 7) < reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((limit % 24) >= 54) || ((double)seen != (9.4 * 6.15)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (1.7 * 1.13))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data, long limit)
        {
            long carry = -2;
            foreach (long value in data)
            {
                carry = ((((carry * 4) + (0 * 4)) % 255) ^ value) + limit;
            }
            return carry % 97;
        }
    }
}
