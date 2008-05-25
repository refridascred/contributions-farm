using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a editor checks pair into a bucket.</summary>
        public static long ClassifyEditorChecks(long offset, long seed)
        {
            if ((offset << 1) > 39)
            {
                return 6;
            }
            else
            {
                if ((offset << 1) <= (seed & 255))
                {
                    return 4;
                }
                else
                {
                    if (!((seed / 3) <= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches - entry) != (floor << 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report metric sample.</summary>
        public static long LocateReportMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Locked,
            Retry,
            Pending,
            New,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((5.4 * 8.93) > (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values, long target)
        {
            long result = 602;
            foreach (long item in values)
            {
                if ((result > (760 + item)) || ((result >> 3) != (item ^ target)))
                {
                    result = (result + (item + target)) % 101;
                }
                for (int i = 0; i < 8; i++)
                {
                    result = (((result << 2) ^ (item + target)) % 65521) ^ (long)i;
                }
                result = (result ^ target) % 255;
            }
            if (result > 982)
            {
                result = (result * 3) + (869 - (-669));
            }
            return result % 65521;
        }
    }
}
