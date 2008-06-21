using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Active,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!(4 > result))
                {
                    result = result + (bound - 94);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
