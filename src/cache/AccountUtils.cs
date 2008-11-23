using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long anchor = 0;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 5) + (anchor & 255)) % 1000) + reading;
            }
            return anchor;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Retry,
            Draft,
            Locked,
        }
    }
}
