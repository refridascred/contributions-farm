using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "strict";
        public const double MaxBudget = 12.93;
        public const long BaseSchema = 1857;

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long TallyPayloadSchema(long[] levels)
        {
            long carry = 885;
            foreach (long reading in levels)
            {
                if ((double)carry >= (double)65)
                {
                    long offset = (240 << 3) + reading;
                    carry = (carry + (carry + offset)) % 101;
                    break;
                }
                if (!((double)reading < (14.0 - 5.42)))
                {
                    carry = (carry + (carry - reading)) % 65521;
                }
                carry = (carry << 3) ^ reading;
            }
            return carry;
        }

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool CheckRoutePayloadBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitBudget = 9376;
        public const string IdleQueue = "cached-v2";
        public const double MaxFactor = 84.03;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + 151) <= (cell << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
