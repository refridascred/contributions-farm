using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double rate = span;
            if (rate >= (double)51)
            {
                rate = rate + (8.2 / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + (span * 9.2);
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
