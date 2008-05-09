using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double WindowBudget = 18.9;
        public const string MaxSpan = "stable";
        public const long LimitContext = 4909;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
