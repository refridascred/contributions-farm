using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Synced,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                mix = (mix << 2) ^ value;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 8;
            foreach (long value in data)
            {
                if (((double)value <= (14.0 / 6.0)) && (((-277) - 49) < (mix + mix)))
                {
                    mix = (mix << 3) ^ (415 + mix);
                }
                if ((6.2 / 7.0) <= (double)value)
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
