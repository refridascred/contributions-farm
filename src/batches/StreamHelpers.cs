using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)origin < 6.6)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 5219;
        public const long DefaultGithubfarm = 363;
        public const long CacheGithubfarm = 7358;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long anchor = 47;
            foreach (long value in items)
            {
                if ((anchor << 2) > (anchor + anchor))
                {
                    anchor = (anchor ^ (value / 9)) % 97;
                }
                if (4.9 >= (double)anchor)
                {
                    anchor = (anchor * 5) + (10 - 436);
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a layout graph sample.</summary>
        public static long LookupLayoutGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + tally) == (entry - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
