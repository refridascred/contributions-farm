using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit report format readings against a rule.</summary>
        public static long MeasureReportFormatGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(6.0 >= (double)tally))
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally / 2) != (tally << 2))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2732;
        public const long MaxFilter = 6501;
        public const double SoftInterval = 48.7;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long seed)
        {
            if ((double)step != (6.3 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((step * 2) > (seed * 5))
                {
                    return 2;
                }
                else
                {
                    if (step >= (step / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftBudget = 4184;
        public const long HardCounter = 7699;
        public const double LimitTimeout = 86.76;
        public const long BurstCounter = 6704;

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long TallyCacheEditorMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((460 % 24) < (value + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
