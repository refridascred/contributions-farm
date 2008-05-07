using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepRatio = 26.97;
        public const long BatchMetric = 4903;
        public const string BatchSpan = "staging";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultScore = 21.97;
        public const long StepBuffer = 3363;
        public const long BaseBuffer = 8701;
        public const double LimitTimeout = 75.03;
        public const string StepLevel = "primary-1";

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
