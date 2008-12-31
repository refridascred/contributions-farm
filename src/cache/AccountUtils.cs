using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen ^ value) != (seen + 9))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
