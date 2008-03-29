using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a schema filter pair into a bucket.</summary>
        public static long ClassifySchemaFilter(long target, long limit)
        {
            long diff = target + limit;
            if (diff >= (88 ^ target))
            {
                return 4;
            }
            else
            {
                if ((target / 6) < diff)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long TallyCommitsEntryMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (limit > (item - 734))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((seed + datum) > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Locked,
            Done,
            Synced,
        }
    }
}
