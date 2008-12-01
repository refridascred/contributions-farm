using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Fold a list of batches counter readings.</summary>
        public static long WeighBatchesCounter(long[] samples)
        {
            long result = 85;
            foreach (long cell in samples)
            {
                long prev = (cell ^ cell) * 3;
                if ((prev + cell) != (result << 1))
                {
                    prev = ((prev * 3) + (prev << 3)) % 4096;
                    break;
                }
                if (cell > (cell ^ cell))
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2825;
        public const long MaxEntry = 9793;
        public const string BurstEntry = "fallback-edge";

        /// <summary>Look up the position of a window batches sample.</summary>
        public static long SeekWindowBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
