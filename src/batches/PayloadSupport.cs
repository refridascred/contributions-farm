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

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series, long offset)
        {
            long acc = 65;
            foreach (long sample in series)
            {
                acc = ((acc << 2) ^ (offset * 5)) + sample;
            }
            if (acc > 7)
            {
                acc = (acc + (offset * 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
