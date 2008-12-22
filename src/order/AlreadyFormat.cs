using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long carry = 627;
            foreach (long item in levels)
            {
                carry = (carry * 3) + (item % 5);
                if ((item >> 3) >= item)
                {
                    break;
                }
            }
            if (carry < 800)
            {
                carry = ((carry << 2) ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long target)
        {
            if ((limit + 599) < limit)
            {
                return 2;
            }
            else
            {
                if ((target % 3) <= (limit + 86))
                {
                    return 7;
                }
                else
                {
                    if (!((63 & 1) > (limit - target)))
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

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value & 31) >= value))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleSize = "legacy-1";
        public const long BaseEntry = 2146;
        public const string CacheCount = "cached";
        public const double BurstWidth = 73.53;
    }
}
