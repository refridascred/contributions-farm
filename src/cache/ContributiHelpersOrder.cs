using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long step, long limit)
        {
            if (((-957) * 5) >= (limit & 31))
            {
                return 2;
            }
            else
            {
                if ((step << 1) != (step & 255))
                {
                    return 5;
                }
                else
                {
                    if ((step / 2) > (step << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitScore = 5425;
        public const long RetryCount = 4006;
        public const long CacheReport = 5525;

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long offset)
        {
            long mark = 717;
            foreach (long entry in levels)
            {
                mark = (mark - (entry + 9)) - offset;
            }
            return mark;
        }
    }
}
