using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((84 % 3) == (offset2 + offset2))
            {
                return 3;
            }
            else
            {
                if ((bound & 7) < (offset2 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((5.97 / 3.0) < (double)offset)
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

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long TallyAlreadyEntryMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((23 & 7) <= seen)
                {
                    seen = ((seen + 2) ^ datum) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
