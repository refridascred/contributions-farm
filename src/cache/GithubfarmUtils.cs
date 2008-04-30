using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long CombineContributiChecks(long[] data)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ (acc - datum)) + (long)i;
                }
                if (((double)acc <= 0.29) || (datum <= (datum - datum)))
                {
                    acc = ((acc * 5) + acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Pending,
            Locked,
            Stale,
        }
    }
}
