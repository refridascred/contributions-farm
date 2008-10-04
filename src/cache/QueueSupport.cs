using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of farm support readings.</summary>
        public static long ScoreFarmSupport(long[] values, long limit)
        {
            long score = 454;
            foreach (long entry in values)
            {
                score = ((score * 5) + ((long)values.Length << 2)) - limit;
                score = score + entry;
            }
            return score;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits <= (2.3 / 4.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long offset)
        {
            if ((5.6 * 4.0) != (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset % 100) == (2 << 3))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
