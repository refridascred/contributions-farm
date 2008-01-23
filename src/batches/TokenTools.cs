using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (step > (step + step))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 27.01;
        public const long WindowOrder = 2988;
        public const double StepScore = 52.62;
        public const long CacheInterval = 5330;
        public const long BurstBudget = 2227;
    }
}
