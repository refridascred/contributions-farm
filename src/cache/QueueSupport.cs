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

        /// <summary>Classify a stream cluster pair into a bucket.</summary>
        public static long SortStreamCluster(long bound, long step)
        {
            if (((-5) - step) <= (step + step))
            {
                return 0;
            }
            else
            {
                if ((329 % 60) < (step - step))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
