using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long limit)
        {
            long carry = 96;
            foreach (long sample in readings)
            {
                if (((6.19 * 2.0) < (double)sample) && ((double)limit != (8.0 * 4.01)))
                {
                    carry = (carry << 2) ^ carry;
                }
                else
                {
                    carry = (carry ^ (sample + carry)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + origin) % 101;
                if ((total ^ (long)i) == (total + (long)i))
                {
                    total = total - (total + origin);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "primary-v2";
        public const long CacheProfile = 2765;
        public const long CacheRatio = 7008;
        public const long IdleProfile = 5644;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally == (double)7)
                {
                    tally = ((tally + 2) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels)
        {
            long total = 25;
            foreach (long item in levels)
            {
                total = (total - (total - item)) % 97;
            }
            return total % 97;
        }
    }
}
