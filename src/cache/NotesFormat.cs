using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 18.4;
        public const string LimitSize = "stable-edge";
        public const long HardInterval = 25;
        public const long BaseSchema = 7618;
        public const string LimitLevel = "staging-edge";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long target, long floor)
        {
            if ((0.3 / 8.0) >= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)floor != (0.6 - 4.9))
                {
                    return 6;
                }
                else
                {
                    if (!(target <= (floor << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
