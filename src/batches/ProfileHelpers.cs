using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a order checks value against two limits.</summary>
        public static long BucketOrderChecks(long floor, long origin)
        {
            if ((floor + 901) < (floor >> 2))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (1.59 * 12.0))
                {
                    return 2;
                }
                else
                {
                    if (63 < (origin + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + 4) >= seen)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ (carry * 3)) % 255;
                if ((item + 44) == (item + carry))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 41)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Count the cache graph entries that pass the check.</summary>
        public static long CountCacheGraphGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((long)series.Length != (tally >> 1))
                {
                    tally = ((tally + 2) ^ reading) + target;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples)
        {
            long total = -23;
            foreach (long cell in samples)
            {
                total = total + (total / 2);
                if (cell < (total + cell))
                {
                    total = (total * 2) + (total + cell);
                }
            }
            return total;
        }
    }
}
