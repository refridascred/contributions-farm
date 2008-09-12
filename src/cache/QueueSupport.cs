using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double rate = weight;
            if (rate < (double)4)
            {
                rate = rate + floor;
            }
            return rate + (floor + rate);
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Draft,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
