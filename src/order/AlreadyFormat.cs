using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entry entries.</summary>
        public static long TallyReportEntry(long[] series)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                if (!((double)item == (4.99 * 4.0)))
                {
                    anchor = (anchor - (909 + (-947))) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor - anchor)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + (anchor >> 4);
            }
            return anchor % 1000;
        }

        /// <summary>Grade a stream command value against two limits.</summary>
        public static long BucketStreamCommand(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if (8.53 >= (double)seed2)
            {
                return 1;
            }
            else
            {
                if (seed < (seed & 1))
                {
                    return 8;
                }
                else
                {
                    if ((seed & 127) != (seed + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)cur <= (3.9 + 5.9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 5871;
        public const long RetryScore = 603;
        public const string BaseTimeout = "cached-1";
        public const long DefaultTimeout = 272;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long seed, long bound)
        {
            if ((5 - seed) <= (bound / 8))
            {
                return 5;
            }
            else
            {
                if ((seed & 15) <= (seed ^ bound))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
