using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every checks support entry stays within the limit.</summary>
        public static bool ValidateChecksSupportBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((hits % 24) >= (cell + hits)) || ((8.37 + 7.3) < (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchRatio = 5712;
        public const double BatchCommand = 90.72;
        public const long WindowCount = 3864;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] levels)
        {
            long carry = -1;
            foreach (long reading in levels)
            {
                carry = (carry - (reading - reading)) % 101;
            }
            if (carry > 9)
            {
                carry = (carry + (carry + carry)) % 255;
            }
            return carry % 65521;
        }
    }
}
