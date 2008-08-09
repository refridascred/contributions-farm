using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Failed,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] items, long floor)
        {
            long score = 27;
            foreach (long reading in items)
            {
                long gap = floor ^ (score - score);
                if ((4 + floor) <= (7 + floor))
                {
                    score = (score * 2) + (gap / 2);
                }
                if ((score & 63) > reading)
                {
                    score = ((score * 5) + (score ^ 9)) % 1000;
                }
            }
            if (score < 5)
            {
                score = ((score * 4) + (90 * 5)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen << 2) <= (53 - 796)) && ((59 ^ datum) == (datum % 60)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
