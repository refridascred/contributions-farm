using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            New,
            Synced,
            Idle,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count ^ count) < datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
