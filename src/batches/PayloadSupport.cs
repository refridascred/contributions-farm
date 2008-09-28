using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 1602;
        public const double LimitCount = 20.43;
        public const string BurstRecord = "open";

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 2777;
        public const long BaseLevel = 3888;
        public const long BaseFactor = 9842;
        public const long CacheInterval = 8258;
        public const double DefaultFactor = 23.22;
    }
}
