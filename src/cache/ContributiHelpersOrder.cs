using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double mean = rate;
            if (mean < (4.2 / 6.0))
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (floor * 7.57);
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Synced,
            Paused,
            Queued,
            Locked,
        }
    }
}
