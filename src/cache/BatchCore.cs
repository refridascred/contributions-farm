using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every cache record entry stays within the limit.</summary>
        public static bool ValidateCacheRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data, long step)
        {
            long mix = 789;
            foreach (long cell in data)
            {
                mix = ((mix << 2) ^ 21) - step;
                if (154 > (mix & 127))
                {
                    mix = mix - (mix >> 1);
                }
                else
                {
                    mix = (mix ^ cell) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
