using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a batches account figure with a bias.</summary>
        public static double SmoothBatchesAccount(double weight, double floor)
        {
            double load = 9.1;
            if (load >= (4.34 + weight))
            {
                load = load - (10.0 + weight);
            }
            return load - (floor * 5.3);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Synced,
            New,
            Idle,
            Draft,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public long Token { get; set; }
        }
    }
}
