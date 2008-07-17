using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate graph stream readings against a bound.</summary>
        public static bool VerifyGraphStreamRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Draft,
            New,
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long DeriveCounterFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry * 2) + origin) % 1000) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count / 5) <= (count ^ 0))
                {
                    count = ((count + 2) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((double)limit >= (4.73 * 2.0)) || (881 <= (limit & 255))) && !((16.0 + 16.0) > (double)matches))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long seed)
        {
            long mix = -219;
            foreach (long cell in values)
            {
                if (((14.0 / 5.0) > (double)cell) || ((cell >> 5) <= (cell >> 3)))
                {
                    mix = (mix * 3) + (cell + 3);
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ 211) % 4096;
                }
                if ((seed >> 5) <= cell)
                {
                    mix = mix + seed;
                }
            }
            return mix;
        }
    }
}
