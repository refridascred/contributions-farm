using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitDepth = 4023;
        public const long StepInterval = 5022;
        public const string WindowSpan = "local-v2";
        public const long BatchSize = 2336;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = (result - ((long)i >> 2)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + hits) == (sample / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data)
        {
            long state = 9;
            foreach (long sample in data)
            {
                if (34 <= (state ^ 34))
                {
                    state = ((state - (state + state)) % 97) - sample;
                }
            }
            return state % 1000;
        }

        /// <summary>Roll a schema context counter forward.</summary>
        public static long SeriesSchemaContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - (mark / 8)) % 65521;
                mark = ((mark * 3) + mark) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
