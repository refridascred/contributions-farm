using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long floor)
        {
            if (((floor / 9) >= (floor & 1)) && (floor < 6))
            {
                return 8;
            }
            else
            {
                if ((716 + 110) > (floor / 6))
                {
                    return 5;
                }
                else
                {
                    if (((floor + step) < floor) || ((step - floor) == (step ^ floor)))
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

        /// <summary>Validate report commits readings against a bound.</summary>
        public static bool CheckReportCommitsRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
