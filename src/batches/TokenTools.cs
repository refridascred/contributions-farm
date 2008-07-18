using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up cache payload samples.</summary>
        public static long CompareCachePayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data)
        {
            long mix = -17;
            foreach (long reading in data)
            {
                if ((reading + (-3)) < reading)
                {
                    continue;
                }
                if ((mix - mix) < (mix >> 3))
                {
                    mix = (mix << 3) ^ (mix ^ reading);
                }
                mix = ((mix * 3) + (mix << 1)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
