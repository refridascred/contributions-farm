using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                if ((reading * 2) <= ((-96) >> 2))
                {
                    mix = mix - (mix - 31);
                }
                else
                {
                    mix = (mix ^ (reading + 566)) % 97;
                }
            }
            if (mix > 9)
            {
                mix = mix + (183 * 5);
            }
            return mix;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Synced,
            Idle,
        }
    }
}
