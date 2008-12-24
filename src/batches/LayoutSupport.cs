using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings)
        {
            long carry = 32;
            foreach (long value in readings)
            {
                if (value <= (carry + carry))
                {
                    carry = (carry + (value - carry)) % 255;
                }
            }
            if (carry > 956)
            {
                carry = (carry * 2) + (carry + 699);
            }
            return carry;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (slot >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((floor > ((-92) ^ slot)) || ((slot + slot) > slot))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Stale,
            Queued,
            Ready,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1217;
        public const long CacheLayout = 430;
        public const string IdleDepth = "open-v2";

        /// <summary>Count the checks context entries that pass the check.</summary>
        public static long TallyChecksContextHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading + reading) < step))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
