using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long state = 5;
            foreach (long value in data)
            {
                if (state > (state >> 5))
                {
                    state = (state * 2) + value;
                }
                else
                {
                    state = (state << 2) ^ (state ^ value);
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long step)
        {
            long score = -10;
            foreach (long cell in readings)
            {
                score = (score ^ (step >> 5)) % 97;
                if (!((cell * 5) <= (step + 923)))
                {
                    score = ((score << 3) ^ (score << 2)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double ratio = (double)(5 << 2);
            if (ratio >= ratio)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - 7.61;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio + (double)346;
        }
    }
}
