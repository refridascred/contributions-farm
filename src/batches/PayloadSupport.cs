using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) > (cell + cell))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
