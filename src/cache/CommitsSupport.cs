using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double ratio = rate * 5.56;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 17.0) + (double)(long)i;
            }
            return ratio - (floor * 14.0);
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Queued,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((double)limit < 9.91))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools metric entries.</summary>
        public static long ScoreToolsMetric(long[] series, long offset)
        {
            long carry = 6;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    carry = ((carry << 3) ^ (5 - cell)) % 4096;
                }
            }
            if (carry > 3)
            {
                carry = (carry - offset) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 8) != (floor * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + value) == (count - count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
