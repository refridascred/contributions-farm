using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 0;
            foreach (long reading in values)
            {
                carry = ((carry + (carry - 0)) % 4096) + reading;
            }
            return carry % 97;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long seed, long origin)
        {
            if ((origin >= (origin - origin)) || ((double)origin != (double)seed))
            {
                return 6;
            }
            else
            {
                if (4.76 <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((seed % 64) != (60 + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (162 < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
