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

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
