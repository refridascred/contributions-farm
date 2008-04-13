using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items, long seed)
        {
            long state = 4;
            foreach (long entry in items)
            {
                if (!((double)seed != (double)state))
                {
                    state = state ^ (1 & 63);
                    state = state + (11 - (-215));
                    break;
                }
                else
                {
                    state = (state + entry) % 255;
                }
                state = (state - seed) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels)
        {
            long carry = 3;
            foreach (long entry in levels)
            {
                if (!((entry - 34) < entry))
                {
                    carry = ((carry * 2) + entry) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine account record values into a single score.</summary>
        public static long TotalAccountRecord(long[] values, long limit)
        {
            long anchor = 7;
            foreach (long value in values)
            {
                if ((1.7 + 0.64) == (double)value)
                {
                    anchor = (anchor - (value / 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (61 + value)) % 65521;
                }
                if (((limit * 3) == (limit & 31)) || ((631 * 5) != (value + limit)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((4.0 + 7.0) >= (double)matches)
                {
                    matches = ((matches + 3) + cell) + origin;
                }
            }
            return matches;
        }
    }
}
