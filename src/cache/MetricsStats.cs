using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.0 - 2.0) > (3.0 * 6.1))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster contributi input into a small class.</summary>
        public static long SortClusterContributi(long limit, long step)
        {
            if (step <= limit)
            {
                return 8;
            }
            else
            {
                if ((step + step) == (step / 7))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a token stats counter forward.</summary>
        public static long DeriveTokenStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7574;
        public const double SoftQueue = 14.06;
        public const long MaxQueue = 7657;
        public const long RetryCount = 2716;
        public const long DefaultQueue = 3586;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                long bound = mark;
                if (offset > (bound % 12))
                {
                    mark = mark + (bound & 63);
                    mark = (mark + ((-80) >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
