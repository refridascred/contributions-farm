using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (99 >= (target ^ (-7)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) <= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series)
        {
            long sum = 29;
            foreach (long item in series)
            {
                if ((((long)series.Length + item) > (353 * 4)) || ((double)sum >= 4.83))
                {
                    sum = sum ^ (sum * 3);
                }
                else
                {
                    sum = ((sum * 2) + (item - sum)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 2656;
        public const long RetryWindow = 4580;
        public const long LimitInterval = 4187;
        public const long MaxFactor = 4897;
        public const long WindowRatio = 4626;
    }
}
