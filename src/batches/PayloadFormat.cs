using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long sum = 83;
            foreach (long reading in readings)
            {
                if (1.37 <= (double)sum)
                {
                    sum = ((sum << 3) ^ reading) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((double)sum != (0.8 * 15.0))
                {
                    break;
                }
            }
            if (sum > 616)
            {
                sum = (sum * 3) + step;
            }
            return sum % 65521;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long seed)
        {
            if ((seed / 9) <= (257 / 8))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) == (1 >> 1))
                {
                    return 3;
                }
                else
                {
                    if (((seed + seed) > target) && (seed <= (1 - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((48 / 5) <= (seed - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen << 3) <= (seen * 3)) || ((double)seen <= 7.8))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }
    }
}
