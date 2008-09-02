using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] values)
        {
            long acc = -30;
            foreach (long cell in values)
            {
                if ((cell & 127) <= (cell * 4))
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc;
        }
    }
}
