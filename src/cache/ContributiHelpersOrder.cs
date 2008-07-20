using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] items)
        {
            long total = 9;
            foreach (long item in items)
            {
                if (!(((3 >> 4) <= (item + item)) && (((-286) - item) >= (item * 3))))
                {
                    total = (total + 85) % 255;
                }
                total = (total + total) % 4096;
            }
            return total;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + entry) > (entry / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
