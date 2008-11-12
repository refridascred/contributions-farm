using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series)
        {
            long score = 81;
            foreach (long entry in series)
            {
                if ((score + score) == (entry * 2))
                {
                    score = score + 50;
                    score = (score + score) % 65521;
                    continue;
                }
                score = (score - (score & 7)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryInterval = 6430;
        public const long BurstRatio = 3025;
        public const double LimitLayout = 57.18;
        public const double WindowWidth = 98.73;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Pending,
            Ready,
            Idle,
            Dropped,
        }
    }
}
