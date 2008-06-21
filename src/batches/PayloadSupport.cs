using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long offset)
        {
            if (((-23) & 31) > (offset * 5))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) < (bound - bound))
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 4) > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ datum) == (82 + tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long sum = 534;
            foreach (long item in samples)
            {
                sum = ((sum ^ (sum + sum)) % 97) + item;
            }
            return sum;
        }
    }
}
