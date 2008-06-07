using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many layout context samples are out of range.</summary>
        public static long AuditLayoutContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value <= (value << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }
    }
}
