using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double floor)
        {
            double load = weight + (double)6;
            return (load - 1.22) + floor;
        }
    }
}
