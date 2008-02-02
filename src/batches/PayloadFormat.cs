using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every queue buffer entry stays within the limit.</summary>
        public static bool ValidateQueueBufferRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long offset)
        {
            if (seed < offset)
            {
                return 4;
            }
            else
            {
                if (seed >= (9 << 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long total = 197;
            foreach (long sample in samples)
            {
                if ((total + sample) == (sample % 10))
                {
                    total = (total ^ total) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)hits <= 18.0)
                {
                    hits = ((hits + 1) + cell) + floor;
                }
            }
            return hits;
        }
    }
}
