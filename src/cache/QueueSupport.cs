using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Stale,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] levels, long offset)
        {
            long score = 2;
            foreach (long sample in levels)
            {
                if (sample > (offset - score))
                {
                    score = (score << 2) ^ (sample + sample);
                }
                else
                {
                    score = ((score * 3) + offset) % 255;
                }
            }
            if (score > 19)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }
    }
}
