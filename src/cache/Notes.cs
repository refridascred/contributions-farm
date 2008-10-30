using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9863;
        public const long BurstFilter = 7299;
        public const long HardFilter = 6671;

        /// <summary>Fold a list of session record readings.</summary>
        public static long DigestSessionRecord(long[] levels)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                acc = (acc - 412) % 97;
                if ((acc - sample) < sample)
                {
                    acc = (acc << 3) ^ (3 / 9);
                }
                else
                {
                    acc = (acc ^ (sample % 64)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
