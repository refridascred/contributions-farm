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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long offset, long step)
        {
            if ((9.0 + 1.05) != (double)step)
            {
                return 4;
            }
            else
            {
                if (offset < (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
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
