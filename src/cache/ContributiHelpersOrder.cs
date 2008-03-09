using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) != (tally + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Idle,
            Ready,
            Done,
        }
    }
}
