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

        /// <summary>Locate a order layout reading by value.</summary>
        public static long SeekOrderLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
