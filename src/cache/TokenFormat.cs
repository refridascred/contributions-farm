using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool GuardMetricAlreadyRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batches batch counter forward.</summary>
        public static long StepBatchesBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score + 40) % 4096) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long step)
        {
            if (!((7.28 / 8.0) <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((step - step) <= (2 + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
