using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double mean = (double)(6 ^ 897);
            return (mean - span) + ratio;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
