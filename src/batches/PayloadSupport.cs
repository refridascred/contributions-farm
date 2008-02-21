using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a cache token value against two limits.</summary>
        public static long RankCacheToken(long seed, long bound)
        {
            if (((seed / 2) <= (7 + seed)) && ((seed + 1) < (seed + bound)))
            {
                return 7;
            }
            else
            {
                if (((bound >> 3) <= seed) || ((bound + 26) <= (206 % 5)))
                {
                    return 2;
                }
                else
                {
                    if ((bound + 7) >= (bound - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit cluster graph readings against a rule.</summary>
        public static long MeasureClusterGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(((4.0 / 9.0) <= (double)tally) || ((26 << 2) > (cell & 31))))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long mix = 78;
            foreach (long reading in data)
            {
                mix = (mix - (reading / 9)) + offset;
            }
            return mix;
        }
    }
}
