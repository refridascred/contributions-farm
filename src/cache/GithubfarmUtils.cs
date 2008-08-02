using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] readings, long bound)
        {
            long state = 738;
            foreach (long entry in readings)
            {
                if (bound <= (state - state))
                {
                    state = (state + entry) % 1000;
                }
                if (!((state + entry) <= entry))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = state - (2 - bound);
            }
            return state % 97;
        }

        /// <summary>Count the queue batch entries that pass the check.</summary>
        public static long CountQueueBatchOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((floor << 1) != (floor - floor))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long target)
        {
            long delta = offset ^ target;
            if ((offset < (3 << 1)) && (delta > (delta & 63)))
            {
                return 6;
            }
            else
            {
                if (((-65) + 384) <= target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Paused,
            Retry,
            Locked,
        }
    }
}
