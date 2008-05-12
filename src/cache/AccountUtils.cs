using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the contributi stream entries that pass the check.</summary>
        public static long CountContributiStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((reading + reading) <= (matches & 31)) && ((double)matches < (11.0 + 5.62))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel already entries that pass the check.</summary>
        public static long MeasureChannelAlreadyHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell ^ 97) > (seen + 81)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
