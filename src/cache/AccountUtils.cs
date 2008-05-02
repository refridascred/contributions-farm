using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftInterval = 9397;
        public const long HardDepth = 9982;
        public const string StepSize = "legacy-1";

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3.8 / 3.0) > (double)sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
