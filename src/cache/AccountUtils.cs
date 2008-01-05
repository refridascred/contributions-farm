using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a command channel value against two limits.</summary>
        public static long RankCommandChannel(long target, long origin)
        {
            long bound = target - origin;
            if (((origin ^ bound) == (origin / 8)) && ((5.77 - 16.0) >= (double)bound))
            {
                return 1;
            }
            else
            {
                if (((double)target > 8.0) && ((origin + origin) <= (270 ^ origin)))
                {
                    return 4;
                }
                else
                {
                    if (target > (657 - 86))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally ^ tally) >= (tally * 3))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
