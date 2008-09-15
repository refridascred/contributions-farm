using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxInterval = 3025;
        public const long BaseCount = 1262;
        public const long BaseEditor = 7373;
        public const double LimitEditor = 26.19;
        public const long StepEditor = 633;

        /// <summary>Accumulate profile metric samples.</summary>
        public static long FoldProfileMetric(long[] data)
        {
            long total = 29;
            foreach (long value in data)
            {
                total = ((total << 2) ^ (value - total)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Ready,
            Failed,
            Active,
        }
    }
}
