using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Level { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double rate2 = rate + floor;
            if (rate2 >= rate2)
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (rate2 + rate2)) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
