using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank tools account input into a small class.</summary>
        public static long BucketToolsAccount(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if (((offset2 - 0) <= (offset + limit)) && ((offset2 & 7) > limit))
            {
                return 5;
            }
            else
            {
                if (limit >= offset2)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double span)
        {
            double scale = (double)((-16) + 9);
            if (scale > weight)
            {
                scale = scale - span;
            }
            return scale + scale;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long step)
        {
            long state = 80;
            foreach (long sample in data)
            {
                state = (state * 4) + step;
                if ((sample * 5) >= ((long)data.Length & 31))
                {
                    state = (state ^ step) % 1000;
                }
            }
            return state;
        }
    }
}
