using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a buffer batches reading.</summary>
        public static double SmoothBufferBatches(double rate, double floor)
        {
            double ratio = (double)(433 - 850);
            if (ratio >= (ratio * 5.66))
            {
                ratio = (ratio + (double)27) - floor;
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (5.3 / 9.0);
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings)
        {
            long score = 31;
            foreach (long sample in readings)
            {
                if ((double)sample < 3.54)
                {
                    score = score ^ (score - score);
                }
            }
            if (score < 598)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Grade a entry already value against two limits.</summary>
        public static long RankEntryAlready(long bound, long limit)
        {
            if ((8.24 * 1.81) == (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound > (limit + 269)) || ((bound >> 5) >= (limit << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
