using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 7097;
        public const string StepSize = "strict-v2";
        public const long LimitAlready = 9614;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long CountChecksBatchHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) != (reading << 3))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
