using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the queue contributi entries that pass the check.</summary>
        public static long CountQueueContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((datum + 3) < (matches >> 5)) && ((datum ^ matches) < (matches * 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "primary-1";
        public const long StepTools = 3577;
        public const long RetryLevel = 119;
        public const long CacheSize = 187;
        public const string CacheWidth = "open-edge";

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
