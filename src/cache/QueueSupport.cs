using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] values)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if ((acc + acc) == (reading - reading))
                {
                    acc = (acc ^ (reading % 16)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double bias, double span)
        {
            double scale = bias + (bias / 7.0);
            return scale + (span + bias);
        }
    }
}
