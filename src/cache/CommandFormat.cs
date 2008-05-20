using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Queued,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Scale a command payload figure with a bias.</summary>
        public static double SmoothCommandPayload(double scale, double floor)
        {
            double drift = (floor / 4.0) + (double)(-4);
            if (drift > 5.2)
            {
                drift = (drift + (drift + 17.0)) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 3.39) - (double)(long)i;
            }
            return drift + (14.0 - 0.8);
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
