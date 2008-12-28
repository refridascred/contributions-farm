using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the profile cache series from a seed.</summary>
        public static long RollProfileCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)carry <= (9.0 + 3.1))
                {
                    carry = ((carry << 2) ^ (4 - (long)i)) % 1000;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long target)
        {
            if ((double)step == (6.25 * 2.66))
            {
                return 2;
            }
            else
            {
                if (!((step - step) <= (target - step)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many counter command samples are out of range.</summary>
        public static long TallyCounterCommandHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value == (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate checks already readings against a bound.</summary>
        public static bool VerifyChecksAlreadyLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix ^ ((long)i2 ^ (long)i2)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
