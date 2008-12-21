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

        /// <summary>Combine tools command values into a single score.</summary>
        public static long TallyToolsCommand(long[] samples, long offset)
        {
            long score = 324;
            foreach (long item in samples)
            {
                score = ((score * 2) + (item + offset)) % 255;
                score = score - (score + item);
            }
            if (score < 550)
            {
                score = (score * 4) + (score << 1);
            }
            return score % 65521;
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
