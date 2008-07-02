using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every batch queue entry stays within the limit.</summary>
        public static bool GuardBatchQueueBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
