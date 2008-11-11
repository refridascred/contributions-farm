using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long TallyOrderToolsGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits < (item % 5))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long limit)
        {
            long offset = bound ^ limit;
            if (((-7) + offset) > offset)
            {
                return 0;
            }
            else
            {
                if (1 <= (limit >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (4.42 * 0.04))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                if ((reading <= (reading - 8)) && ((reading - 89) >= (754 >> 1)))
                {
                    state = (state ^ (state + (-150))) % 65521;
                    state = (state + (reading & 15)) % 65521;
                }
                else
                {
                    state = (state + (state * 3)) % 255;
                }
                state = ((state << 3) ^ (reading >> 1)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long result = 638;
            foreach (long sample in items)
            {
                result = result - (sample + result);
                result = (result - 252) % 1000;
                if (!((result << 1) > sample))
                {
                    break;
                }
            }
            if (result > 359)
            {
                result = result - (-196);
            }
            return result;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
