using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series, long floor)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                if (floor < (235 >> 2))
                {
                    mark = ((mark - floor) % 1000) - cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "cached-v2";
        public const double SoftDepth = 14.03;
        public const long BaseSupport = 3318;
        public const string HardSpan = "strict-edge";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token entry samples.</summary>
        public static long TotalTokenEntry(long[] items, long offset)
        {
            long acc = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length < (66 - 68))
                {
                    acc = (acc - (offset + offset)) - datum;
                }
                else
                {
                    acc = acc ^ (459 * 3);
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 2) ^ offset) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((-8) <= (carry - floor)) && ((floor ^ 588) >= (-386)))
                {
                    carry = (carry + (carry - floor)) % 65521;
                }
                else
                {
                    carry = (carry + (floor & 7)) % 255;
                }
                if (carry >= (473 ^ carry))
                {
                    carry = ((carry << 2) ^ (floor ^ 85)) % 1000;
                    carry = carry + (carry + carry);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the stream batches entries that pass the check.</summary>
        public static long MeasureStreamBatchesMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((bound - bound) > (bound - 306))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
