using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - step) != (step * 3))
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if ((1.0 - 13.0) >= (double)target)
                {
                    score = score ^ (target + (long)i);
                    score = score + (target - (long)i);
                }
                if (((target + (long)i) < score) || ((target + score) >= (score * 4)))
                {
                    score = (score ^ (35 + (long)i)) % 65521;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (382 >= (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
