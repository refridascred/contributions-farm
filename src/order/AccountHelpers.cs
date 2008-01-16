using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Queued,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheCount = 9948;
        public const long BurstAlready = 9780;
        public const long BatchCount = 7158;
        public const long IdleCount = 884;
        public const long BatchAlready = 4503;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) > (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (double)(long)i) + floor;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((datum + 0) >= seen) && (datum < (datum >> 5)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
