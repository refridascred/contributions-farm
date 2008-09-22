using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseCount = 3243;
        public const long RetryInterval = 5908;
        public const long RetryDepth = 9828;
        public const string MaxCount = "open";

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3010;
        public const double CacheRatio = 56.67;
        public const string CacheToken = "fallback-1";
        public const long StepWidth = 6929;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((bound - 0) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "legacy";
        public const long IdleGraph = 8594;
        public const long LimitInterval = 4199;
    }
}
