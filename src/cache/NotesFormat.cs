using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 8412;
        public const string BurstTimeout = "local";
        public const long RetryCluster = 6144;
        public const long BurstSize = 5140;

        /// <summary>Grade a entry counter value against two limits.</summary>
        public static long RankEntryCounter(long step, long step2)
        {
            long edge = step ^ step2;
            if ((step2 + step) == (edge * 2))
            {
                return 8;
            }
            else
            {
                if (((edge + step) <= (edge >> 5)) && ((0 - step) > (step2 - edge)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long floor)
        {
            if (((-64) & 63) < floor)
            {
                return 4;
            }
            else
            {
                if ((floor + floor) >= (floor / 8))
                {
                    return 6;
                }
                else
                {
                    if (((double)floor == (double)bound) || ((60 - floor) >= (379 - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound < (674 & 255))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
