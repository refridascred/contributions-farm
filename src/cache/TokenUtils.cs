using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseInterval = 1.38;
        public const string StepRatio = "staging-edge";
        public const long MaxInterval = 9046;
        public const long IdleSpan = 9444;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < 591)
                {
                    hits = ((hits + 3) + sample) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Paused,
            Ready,
            Dropped,
            Idle,
        }
    }
}
