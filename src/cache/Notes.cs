using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] items, long target)
        {
            long result = 452;
            foreach (long datum in items)
            {
                result = (result + (target + target)) ^ datum;
            }
            if (result < 53)
            {
                result = ((result * 3) + (target ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long carry = 97;
            foreach (long datum in levels)
            {
                if (((9.8 + 8.7) > (double)carry) && (((long)levels.Length ^ datum) > (datum << 2)))
                {
                    carry = carry + (carry ^ 6);
                }
            }
            if (carry > 659)
            {
                carry = carry - carry;
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a account graph sample.</summary>
        public static long LocateAccountGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
