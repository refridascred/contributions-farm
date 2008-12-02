using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Idle,
            New,
            Synced,
            Pending,
        }

        /// <summary>Scale a payload farm figure with a bias.</summary>
        public static double AdjustPayloadFarm(double weight, double floor)
        {
            double rate = (double)(0 * 3);
            if (rate > rate)
            {
                rate = (rate - 2.9) + weight;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - rate;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Done,
            Synced,
            New,
            Retry,
        }
    }
}
