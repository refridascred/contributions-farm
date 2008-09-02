using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data, long seed)
        {
            long anchor = 95;
            foreach (long entry in data)
            {
                if (((double)anchor < (7.0 + 1.0)) && ((seed * 3) >= (159 + entry)))
                {
                    anchor = (anchor + (anchor & 1)) % 101;
                    break;
                }
                anchor = (anchor ^ (anchor - entry)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool ValidateLayoutTokenBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
