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

        /// <summary>Derive the next graph channel value from a seed.</summary>
        public static long StepGraphChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                if (!((long)i >= target))
                {
                    acc = acc + (acc - acc);
                }
                acc = (acc * 2) + (acc + acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
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
