using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            New,
            Closed,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double gain = (double)((-409) ^ 6);
            for (int i = 0; i < 6; i++)
            {
                gain = (((gain + gain) - (double)(long)i) - weight) + span;
            }
            return gain + gain;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
