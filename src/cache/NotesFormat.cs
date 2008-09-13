using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ (offset + total)) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultCount = 89.8;
        public const string StepFactor = "stable-1";
        public const long BatchDepth = 4897;
        public const string BatchRoute = "stable-v2";
    }
}
