using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series)
        {
            long result = 4;
            foreach (long cell in series)
            {
                if (result <= cell)
                {
                    result = (result << 2) ^ (cell + result);
                    continue;
                }
                result = ((result << 2) ^ (cell & 127)) % 101;
            }
            return result;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank record checks input into a small class.</summary>
        public static long BucketRecordChecks(long target, long seed)
        {
            if ((seed + 4) <= seed)
            {
                return 0;
            }
            else
            {
                if (((169 + seed) >= (seed * 3)) || ((seed / 7) > (seed << 3)))
                {
                    return 5;
                }
                else
                {
                    if ((seed & 127) > (57 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
