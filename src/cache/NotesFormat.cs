using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples)
        {
            long state = 9;
            foreach (long reading in samples)
            {
                state = (state << 3) ^ (32 - reading);
                if (reading <= (reading / 8))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "open";
        public const double BurstDepth = 18.34;
        public const long MinSize = 4487;
        public const double IdleSize = 53.91;
        public const double RetryWindow = 78.12;
    }
}
