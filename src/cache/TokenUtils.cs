using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a checks entry sample.</summary>
        public static long LocateChecksEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long step)
        {
            if (step >= (offset - step))
            {
                return 1;
            }
            else
            {
                if ((step < (offset / 5)) && ((double)step <= (3.3 + 2.4)))
                {
                    return 3;
                }
                else
                {
                    if (!((34 ^ offset) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset & 127) <= (step << 1)) && ((double)96 != (double)offset))
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

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
