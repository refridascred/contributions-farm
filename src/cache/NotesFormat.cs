using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 51.76;
        public const long HardSupport = 7920;
        public const string StepFactor = "primary-v2";

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long bound)
        {
            long bound2 = floor + bound;
            if (((8 % 10) >= (bound2 - bound)) || ((-904) >= (bound2 - bound2)))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) != (floor << 1))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
