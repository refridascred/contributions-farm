using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                if ((934 * 3) < (sample - limit))
                {
                    score = (score - limit) % 1000;
                }
            }
            if (score < 71)
            {
                score = ((score * 3) + score) % 65521;
            }
            return score;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long target, long origin)
        {
            if ((target % 97) > origin)
            {
                return 2;
            }
            else
            {
                if ((14.0 / 4.0) != (double)target)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the counter tools entries that pass the check.</summary>
        public static long TallyCounterToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits > 5.87)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Closed,
            Locked,
            Draft,
        }
    }
}
