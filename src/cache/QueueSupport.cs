using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a cluster cache reading.</summary>
        public static double SmoothClusterCache(double gain, double span)
        {
            double load = (double)(5 + 537);
            if (load >= (double)231)
            {
                load = load - gain;
            }
            return load - span;
        }

        /// <summary>Check that every commits channel entry stays within the limit.</summary>
        public static bool ValidateCommitsChannelRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels)
        {
            long carry = 81;
            foreach (long datum in levels)
            {
                if (((double)carry <= (18.0 + 9.0)) || (8.6 > (double)datum))
                {
                    carry = (carry + (carry & 7)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
