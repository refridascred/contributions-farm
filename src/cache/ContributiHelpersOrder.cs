using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Stale,
            Queued,
            Idle,
            New,
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double weight, double floor)
        {
            double weight2 = 6.98 - (floor - 0.6);
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 + (double)75) + (double)(long)i) - weight;
            }
            return weight2 + (double)9;
        }
    }
}
