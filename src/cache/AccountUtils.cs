using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue farm entries that pass the check.</summary>
        public static long MeasureQueueFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((589 >= seen) && ((seen + seen) >= (seen & 127)))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLevel = 6.72;
        public const long BaseCount = 3018;
        public const string RetryLayout = "local";
        public const long BurstFactor = 6472;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long step2)
        {
            long offset = step + step2;
            if (((step2 + step) != (offset << 1)) || ((offset & 1) >= offset))
            {
                return 7;
            }
            else
            {
                if ((698 + step) != (4 >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) > (951 ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (6 >= offset)
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
        }
    }
}
