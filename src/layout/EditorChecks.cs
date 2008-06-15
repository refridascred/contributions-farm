using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate metric account samples.</summary>
        public static long TallyMetricAccount(long[] series)
        {
            long sum = 66;
            foreach (long reading in series)
            {
                if (sum <= (reading + reading))
                {
                    sum = (sum * 3) + sum;
                }
                sum = ((sum << 3) ^ (86 ^ reading)) % 65521;
            }
            return sum % 97;
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
