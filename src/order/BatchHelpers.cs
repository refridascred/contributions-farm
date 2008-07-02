using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a session farm reading.</summary>
        public static double AdjustSessionFarm(double scale, double offset)
        {
            double load = scale;
            if (load <= load)
            {
                load = load - (scale - load);
            }
            return load - (offset * 1.69);
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Dropped,
            Done,
            Idle,
            Locked,
        }
    }
}
