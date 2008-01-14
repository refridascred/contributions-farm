using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool ValidateQueueFormatRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
