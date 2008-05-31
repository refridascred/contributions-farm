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

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Failed,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Combine queue report values into a single score.</summary>
        public static long TotalQueueReport(long[] series, long step)
        {
            long mix = 768;
            foreach (long item in series)
            {
                if ((8 + 67) > (mix - mix))
                {
                    mix = ((mix << 2) ^ item) + step;
                }
            }
            return mix % 97;
        }
    }
}
