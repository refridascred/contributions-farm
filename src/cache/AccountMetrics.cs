using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((matches - origin) < (matches ^ item)) && ((double)matches > (5.8 / 8.0))) && ((854 >> 4) <= (matches << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 3) ^ total) % 1000;
                total = (total << 3) ^ (limit + limit);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count githubfarm route pairs that satisfy a relation.</summary>
        public static long PairGithubfarmRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up batch token samples.</summary>
        public static long CompareBatchTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster filter entry stays within the limit.</summary>
        public static bool CheckClusterFilterRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
