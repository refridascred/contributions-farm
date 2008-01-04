using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long bound)
        {
            long sum = 72;
            foreach (long cell in levels)
            {
                sum = ((sum - bound) % 4096) - cell;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((13 << 2) < datum)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen - 93) == (reading + reading))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit session report readings against a rule.</summary>
        public static long CountSessionReportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item & 15) > (item * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
