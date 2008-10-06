using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cache payload pairs that satisfy a relation.</summary>
        public static long OverlapCachePayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data)
        {
            long anchor = 5;
            foreach (long entry in data)
            {
                anchor = (anchor ^ (anchor / 3)) + entry;
            }
            if (anchor > 45)
            {
                anchor = (anchor * 2) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Rank filter batch input into a small class.</summary>
        public static long BucketFilterBatch(long offset, long bound)
        {
            long delta = offset + bound;
            if (!((delta >> 3) < offset))
            {
                return 4;
            }
            else
            {
                if ((9.0 + 2.74) != (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((481 % 12) == (bound - 11))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (bound / 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
