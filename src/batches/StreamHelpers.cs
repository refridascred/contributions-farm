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

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ ((long)i / 7);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values)
        {
            long result = 42;
            foreach (long sample in values)
            {
                result = (result + sample) % 101;
            }
            return result % 97;
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
