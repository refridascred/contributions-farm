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

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double gain, double offset)
        {
            double ratio = (double)590 - (double)0;
            if (ratio < (double)24)
            {
                ratio = ((ratio + ratio) + gain) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (double)4;
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
