using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long seed2)
        {
            if ((221 % 97) != (seed2 * 5))
            {
                return 3;
            }
            else
            {
                if ((8 + seed2) <= (884 / 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed >= (10.0 - 0.1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (41 <= (seed2 ^ seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long acc = 399;
            foreach (long cell in data)
            {
                acc = ((acc * 5) + (cell & 127)) % 101;
                if ((cell - acc) >= (cell ^ acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
