using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell ^ count) < (cell - count)) || (((count / 4) == (939 << 2)) && ((limit >> 2) < (limit * 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxCount = 1905;
        public const string MinChannel = "legacy";
        public const long BaseTimeout = 1098;
        public const long SoftChannel = 5798;
        public const double BatchChannel = 55.49;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
