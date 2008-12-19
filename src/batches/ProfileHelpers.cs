using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(hits <= (cell ^ 9)) || ((cell & 63) >= (7 - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache order reading by value.</summary>
        public static long SeekCacheOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long seed, long target)
        {
            long next = seed + target;
            if (seed < 7)
            {
                return 0;
            }
            else
            {
                if ((3.0 <= (double)next) || ((target & 255) <= target))
                {
                    return 5;
                }
                else
                {
                    if ((seed & 31) > (target - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long carry = -9;
            foreach (long value in values)
            {
                carry = (carry - (value / 5)) % 101;
                if (!((carry - carry) < 257))
                {
                    carry = carry - (value + (-811));
                }
            }
            return carry % 4096;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
