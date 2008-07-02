using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                if ((double)datum >= (6.0 - 11.0))
                {
                    anchor = anchor ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 5188;
        public const long LimitPayload = 9401;
        public const string BaseInterval = "primary-1";
        public const string MinPayload = "staging-edge";
    }
}
