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

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            New,
            Stale,
            Paused,
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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((2.2 < (double)value) && ((value << 1) > (matches >> 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
