using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long offset)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = result - (offset + cell);
            }
            if (result < 4)
            {
                result = ((result * 2) + (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a cache context value against two limits.</summary>
        public static long BucketCacheContext(long floor, long target)
        {
            if ((target ^ floor) != (floor + target))
            {
                return 4;
            }
            else
            {
                if (!((6 + floor) < floor))
                {
                    return 3;
                }
                else
                {
                    if (!(floor > (floor * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + 905) >= floor)
                        {
                            return 2;
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
}
