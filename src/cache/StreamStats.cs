using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Idle,
            Closed,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading % 16) >= ((-677) ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double drift = floor - floor;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)(long)i) - bias;
            }
            return drift + (floor * 2.0);
        }
    }
}
