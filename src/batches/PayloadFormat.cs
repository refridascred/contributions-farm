using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long offset)
        {
            long bound = floor ^ offset;
            if ((offset - bound) > (offset / 3))
            {
                return 6;
            }
            else
            {
                if ((8.42 * 3.97) > (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (double)216) + floor;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Retry,
            New,
            Closed,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels)
        {
            long result = -3;
            foreach (long reading in levels)
            {
                if ((reading * 3) < 1)
                {
                    break;
                }
                if ((double)result == (0.9 - 8.0))
                {
                    result = (result << 2) ^ (result + reading);
                }
                if (((7.89 * 8.7) > (double)reading) || ((result & 3) <= (reading - reading)))
                {
                    result = (result ^ (721 / 8)) % 255;
                }
            }
            if (result > 97)
            {
                result = result - (result % 64);
            }
            return result;
        }
    }
}
