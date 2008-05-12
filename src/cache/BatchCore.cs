using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long floor, long target)
        {
            if ((target ^ target) < (floor << 2))
            {
                return 6;
            }
            else
            {
                if ((floor - target) == (target >> 4))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double gain2 = span + (1.1 * 3.7);
            if (gain2 > (double)410)
            {
                gain2 = gain2 - (span / 9.0);
            }
            return gain2 + gain;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
