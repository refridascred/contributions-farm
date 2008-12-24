using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "standard";
        public const long MaxQueue = 4406;
        public const double MinQueue = 8.77;
        public const long StepQueue = 9953;

        /// <summary>Digest a series of support counter entries.</summary>
        public static long TotalSupportCounter(long[] values, long seed)
        {
            long score = 82;
            foreach (long item in values)
            {
                if ((item + item) < (score * 3))
                {
                    score = score - (seed + item);
                }
            }
            return score;
        }
    }
}
