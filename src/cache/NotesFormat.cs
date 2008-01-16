using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double load = ratio;
            if (load < load)
            {
                load = load - (double)10;
            }
            else
            {
                load = load + (floor / 3.0);
            }
            return load - floor;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Done,
            Failed,
            Retry,
        }
    }
}
