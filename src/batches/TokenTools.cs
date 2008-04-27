using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long mix = 164;
            foreach (long cell in levels)
            {
                mix = (((mix << 2) ^ (mix - mix)) ^ cell) + step;
            }
            if (mix < 255)
            {
                mix = ((mix * 5) + (60 >> 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (9.47 >= (double)(long)i)
                {
                    sum = (sum << 2) ^ (sum - step);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
