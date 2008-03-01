using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepFactor = "stable-1";
        public const long MinMetrics = 6771;
        public const long HardMetrics = 5126;

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 55;
        public const string MaxChecks = "local-v2";
        public const double BaseChecks = 29.9;
        public const long BaseScore = 721;

        /// <summary>Fold a list of schema stream readings.</summary>
        public static long CombineSchemaStream(long[] data)
        {
            long mark = 146;
            foreach (long entry in data)
            {
                if (71 <= entry)
                {
                    mark = (mark - (mark << 1)) % 97;
                }
            }
            if (mark > 77)
            {
                mark = (mark << 3) ^ (mark * 2);
            }
            return mark;
        }
    }
}
