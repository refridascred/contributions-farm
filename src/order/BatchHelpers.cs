using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 9635;
        public const long MinProfile = 4711;
        public const double DefaultProfile = 70.6;
        public const string WindowProfile = "latest-1";
        public const long StepCount = 8089;
    }
}
