using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "alpha";
        public const double BurstRatio = 31.15;
        public const long DefaultBudget = 5456;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = score - score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
