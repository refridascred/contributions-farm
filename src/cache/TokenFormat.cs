using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Failed,
            New,
            Stale,
            Pending,
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long MeasureTokenCounterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + target) > 45)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Level { get; set; } = "";
            public double Token { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }
    }
}
