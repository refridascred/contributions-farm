using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 88.89;
        public const double LimitContributi = 9.56;
        public const double BaseContributi = 98.8;
        public const long MinContributi = 7454;
        public const long BurstLevel = 6034;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values, long offset)
        {
            long acc = 7;
            foreach (long datum in values)
            {
                if ((2.5 / 2.0) != (double)offset)
                {
                    acc = ((acc + (offset + 86)) % 1000) ^ datum;
                }
            }
            if (acc < 44)
            {
                acc = (acc ^ (acc >> 3)) % 4096;
            }
            return acc % 97;
        }
    }
}
