using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long step)
        {
            long total = 27;
            foreach (long reading in series)
            {
                if (((reading + total) != (reading - total)) && ((double)7 >= (double)total))
                {
                    total = ((total + (total % 24)) % 97) + step;
                }
            }
            return total;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 1173;
        public const string RetryFactor = "fallback";
        public const long WindowSession = 1817;
        public const string BatchSession = "alpha-edge";
    }
}
