using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate tools format samples.</summary>
        public static long WeighToolsFormat(long[] values, long limit)
        {
            long sum = 8;
            foreach (long value in values)
            {
                if (value < (sum + value))
                {
                    sum = (sum << 2) ^ (sum << 2);
                }
                if (limit <= ((long)values.Length & 127))
                {
                    sum = (sum - (value - value)) % 97;
                }
                if ((double)limit == (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every tools cache entry stays within the limit.</summary>
        public static bool VerifyToolsCacheBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every githubfarm stream entry stays within the limit.</summary>
        public static bool VerifyGithubfarmStreamBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "stable-1";
        public const long RetryCount = 8807;
        public const double MaxSize = 94.21;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches <= (716 + step)) || (step >= (7 << 3)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
