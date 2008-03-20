using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings)
        {
            long mark = -5;
            foreach (long sample in readings)
            {
                if ((((-3) & 127) >= (mark << 2)) || ((mark - mark) < (mark * 4)))
                {
                    mark = (mark ^ (mark ^ sample)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((step ^ reading) != (count % 60))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a buffer account pair into a bucket.</summary>
        public static long BucketBufferAccount(long origin, long seed)
        {
            if ((origin << 3) == (seed % 97))
            {
                return 2;
            }
            else
            {
                if ((origin - seed) <= seed)
                {
                    return 7;
                }
                else
                {
                    if (((93 - 6) < seed) && ((seed - origin) == (seed + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
