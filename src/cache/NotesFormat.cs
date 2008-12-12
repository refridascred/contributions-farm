using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchLevel = 69.21;
        public const double MaxSupport = 13.12;
        public const long LimitSupport = 5534;
    }
}
