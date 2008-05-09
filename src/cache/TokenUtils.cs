using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= 6)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Owner { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Done,
            Paused,
        }
    }
}
