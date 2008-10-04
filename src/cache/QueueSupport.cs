using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Failed,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long target)
        {
            long slot = bound - target;
            if ((25 >= bound) || ((double)0 == (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound + slot) > slot)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if ((score / 3) <= (entry - limit))
                {
                    score = (score - (score >> 1)) % 97;
                }
            }
            return score;
        }
    }
}
