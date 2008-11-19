using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 4125;
        public const long WindowBatches = 5572;
        public const long DefaultSpan = 6785;
        public const double WindowWidth = 85.65;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long bound)
        {
            long prev = target + bound;
            if ((double)prev != (1.0 * 16.0))
            {
                return 4;
            }
            else
            {
                if (target >= (bound % 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
