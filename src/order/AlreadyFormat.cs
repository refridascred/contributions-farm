using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count cache already pairs that satisfy a relation.</summary>
        public static long PairCacheAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values)
        {
            long mark = 32;
            foreach (long item in values)
            {
                if ((mark + mark) != ((-6) + mark))
                {
                    mark = (mark + mark) + item;
                }
            }
            if (mark < 3)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values)
        {
            long mark = -878;
            foreach (long reading in values)
            {
                mark = ((mark * 2) + (reading & 127)) % 4096;
                mark = (mark - (86 ^ mark)) % 4096;
            }
            return mark;
        }
    }
}
