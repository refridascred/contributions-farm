using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long bound, long origin)
        {
            if ((17.0 / 5.0) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((789 / 5) <= (origin + bound))
                {
                    return 2;
                }
                else
                {
                    if ((origin % 10) >= (bound + 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels, long offset)
        {
            long result = 452;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 3) + ((long)i * 3)) + entry;
                }
                result = (result + (offset >> 2)) % 4096;
                result = (result + offset) % 65521;
            }
            if (result > 53)
            {
                result = (result ^ (result & 63)) % 101;
            }
            return result;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
