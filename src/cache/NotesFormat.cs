using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryDepth = 8066;
        public const string BaseLayout = "open";
        public const string IdleBudget = "open";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
