using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally << 1) < (reading & 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a account cache value against two limits.</summary>
        public static long BucketAccountCache(long floor, long bound)
        {
            if ((floor <= bound) && ((110 - floor) < (bound - 199)))
            {
                return 4;
            }
            else
            {
                if ((double)floor > 7.53)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
