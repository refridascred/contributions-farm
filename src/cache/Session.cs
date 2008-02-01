using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two context support measurements.</summary>
        public static double AdjustContextSupport(double rate, double span)
        {
            double drift = (rate * 20.0) * 4.92;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Pending,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double mean = (double)(0 + 1);
            if (mean > bias)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - bias2) + (double)(long)i;
            }
            return mean + bias2;
        }
    }
}
