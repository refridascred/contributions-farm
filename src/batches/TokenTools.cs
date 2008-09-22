using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] series)
        {
            long mix = 577;
            foreach (long item in series)
            {
                mix = ((mix + (7 + mix)) % 65521) ^ item;
            }
            return mix;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long BucketReportPayload(long offset, long offset2)
        {
            if ((offset >= 62) || ((42 - 60) >= (offset * 3)))
            {
                return 1;
            }
            else
            {
                if ((offset2 + 82) >= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
