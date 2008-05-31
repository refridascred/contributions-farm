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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseDepth = "primary-1";
        public const long MaxContributi = 2360;
        public const long RetryScore = 7766;
    }
}
