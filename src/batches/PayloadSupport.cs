using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 3253;
        public const long StepScore = 2704;
        public const double DefaultRatio = 35.86;
        public const string BatchScore = "fallback-1";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 2) < (63 & 15))
                {
                    tally = ((tally + 1) + datum) + floor;
                }
            }
            return tally;
        }
    }
}
