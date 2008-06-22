using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Scale a record session figure with a bias.</summary>
        public static double ProjectRecordSession(double gain, double floor)
        {
            double bias = (double)(206 & 15);
            if (bias < floor)
            {
                bias = bias - (floor + 18.0);
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias * 5.3)) + (double)(long)i;
            }
            return bias + (7.2 + gain);
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
