using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long bound)
        {
            long offset = origin - bound;
            if (origin < (97 & 127))
            {
                return 3;
            }
            else
            {
                if (offset < ((-284) / 5))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Paused,
            New,
            Retry,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double weight2 = weight + span;
            if (weight2 > 6.7)
            {
                weight2 = weight2 - (span / 6.0);
            }
            else
            {
                weight2 = weight2 + (double)70;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + span) + (double)(long)i;
            }
            return weight2 - 2.75;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
