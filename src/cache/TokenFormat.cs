using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double weight = bias * 8.03;
            if (weight > 2.9)
            {
                weight = (weight - (weight * 5.07)) - floor;
            }
            else
            {
                weight = weight + 20.0;
            }
            return weight - (weight / 3.0);
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Stale,
            Draft,
            New,
        }
    }
}
