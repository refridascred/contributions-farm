using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double span)
        {
            double mean = span;
            if (mean > (double)380)
            {
                mean = mean + (double)(-8);
            }
            else
            {
                mean = mean - (gain + 14.0);
            }
            return mean - (gain * 8.5);
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((long)items.Length > (value / 8)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
