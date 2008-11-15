using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long step, long limit)
        {
            if ((step - step) > (step + 6))
            {
                return 7;
            }
            else
            {
                if (5.91 >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= (2.8 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double bias)
        {
            double scale = (double)2 - ratio;
            if (scale < scale)
            {
                scale = scale - (scale - 0.2);
            }
            else
            {
                scale = scale - (bias / 5.0);
            }
            return scale - (double)6;
        }
    }
}
