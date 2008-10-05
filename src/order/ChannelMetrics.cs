using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] levels)
        {
            long acc = 6;
            foreach (long datum in levels)
            {
                if (((datum * 2) > acc) || ((acc - acc) > (acc + 825)))
                {
                    acc = ((acc * 4) + (acc ^ datum)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate already record readings against a bound.</summary>
        public static bool GuardAlreadyRecordRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
