using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen >= 16.0)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Idle,
            Failed,
        }
    }
}
