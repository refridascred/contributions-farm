using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double ratio2 = (double)(-736) * 6.0;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 + (floor - ratio2)) + (double)(long)i) - ratio;
            }
            return ratio2 - (floor / 2.0);
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
