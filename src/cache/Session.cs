using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Done,
            New,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double rate, double span)
        {
            double weight = 9.9;
            if (weight <= (weight + 0.38))
            {
                weight = weight - span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (2.57 * 20.0)) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
