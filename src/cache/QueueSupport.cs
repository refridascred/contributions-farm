using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Idle,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double weight = floor / 9.0;
            if (weight < 6.0)
            {
                weight = weight - (rate * 9.18);
            }
            return weight + rate;
        }
    }
}
