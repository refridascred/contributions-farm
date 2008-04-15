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

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
