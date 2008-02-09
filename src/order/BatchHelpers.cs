using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double span)
        {
            double ratio2 = (double)(954 + (-875));
            if (ratio2 <= (double)9)
            {
                ratio2 = (ratio2 - (5.78 / 4.0)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio2) - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((origin & 255) == (score & 63))
                {
                    score = (score << 2) ^ ((long)i / 4);
                }
                if (((665 - score) != (11 + origin)) || ((score + 399) < (origin - (long)i)))
                {
                    score = (score ^ (origin / 8)) % 65521;
                }
                score = score + ((long)i / 7);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
