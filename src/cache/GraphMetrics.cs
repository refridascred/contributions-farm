using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Failed,
            New,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Dropped,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (7.74 - 0.5))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 2519;
        public const long RetryBuffer = 4980;
        public const long StepBuffer = 6499;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseLevel = 21.56;
        public const long MinScore = 1433;
        public const long BaseRatio = 4997;
        public const long IdleSchema = 9299;
        public const long SoftSchema = 1024;
    }
}
