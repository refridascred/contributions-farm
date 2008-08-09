using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] series, long seed)
        {
            long score = 857;
            foreach (long entry in series)
            {
                score = ((score - entry) % 65521) + seed;
            }
            if (score > 814)
            {
                score = score - (score ^ score);
            }
            return score;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Classify a profile schema pair into a bucket.</summary>
        public static long SortProfileSchema(long target, long origin)
        {
            if ((target < (215 - target)) || (target > origin))
            {
                return 3;
            }
            else
            {
                if ((double)origin > (double)target)
                {
                    return 5;
                }
                else
                {
                    if (!((9 << 2) <= (origin + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
