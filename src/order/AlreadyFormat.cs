using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool CheckSchemaEntryBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Digest a series of schema contributi entries.</summary>
        public static long FoldSchemaContributi(long[] readings, long target)
        {
            long anchor = 243;
            foreach (long sample in readings)
            {
                if (!((double)sample == (double)73))
                {
                    anchor = ((anchor << 2) ^ ((long)readings.Length * 4)) % 97;
                }
                else
                {
                    anchor = anchor ^ (target * 3);
                }
            }
            return anchor;
        }
    }
}
