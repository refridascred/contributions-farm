using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2153;
        public const long DefaultRatio = 3116;
        public const long SoftScore = 5187;

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long seed, long target)
        {
            if ((392 * 2) <= (target - seed))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) > target)
                {
                    return 4;
                }
                else
                {
                    if ((target % 8) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate batches counter samples.</summary>
        public static long FoldBatchesCounter(long[] series, long floor)
        {
            long anchor = 99;
            foreach (long reading in series)
            {
                if (!(683 < (7 + anchor)))
                {
                    anchor = (anchor + (anchor + anchor)) % 97;
                    continue;
                }
                if ((floor / 2) <= (reading / 7))
                {
                    anchor = (anchor << 3) ^ (anchor * 4);
                }
                else
                {
                    anchor = (anchor << 3) ^ reading;
                }
                if ((double)anchor > 7.1)
                {
                    anchor = (anchor + floor) % 4096;
                }
            }
            if (anchor < 191)
            {
                anchor = (anchor - ((-1) - floor)) % 65521;
            }
            return anchor;
        }
    }
}
