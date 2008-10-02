using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a channel cluster pair into a bucket.</summary>
        public static long SortChannelCluster(long seed, long floor)
        {
            long offset = seed + floor;
            if (1.0 <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((offset / 2) <= (offset >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed < (5 << 2)) || ((seed & 127) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double weight = offset / 4.0;
            if (weight <= (offset + weight))
            {
                weight = weight + (offset + offset);
            }
            else
            {
                weight = weight - ratio;
            }
            return weight + (double)(-3);
        }
    }
}
