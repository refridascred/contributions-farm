using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the token checks entries that pass the check.</summary>
        public static long TallyTokenChecksMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((step ^ step) <= (seen & 127))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Active,
            Closed,
            Paused,
        }
    }
}
