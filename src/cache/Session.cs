using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (seed <= (matches % 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Failed,
            Paused,
            New,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long target)
        {
            long score = 234;
            foreach (long datum in values)
            {
                if (((1.18 * 4.2) == (double)score) || ((target ^ target) > score))
                {
                    score = ((score - (target - 156)) % 4096) + datum;
                }
            }
            return score;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Draft,
            Pending,
        }
    }
}
