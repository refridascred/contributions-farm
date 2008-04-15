using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Done,
            Retry,
            Pending,
            Failed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (double)7)
            {
                drift = (drift + drift) + offset;
            }
            return drift - drift;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long ClassifyContextGithubfarm(long origin, long seed)
        {
            long edge = origin + seed;
            if ((edge + origin) < (77 - 744))
            {
                return 2;
            }
            else
            {
                if ((0.1 + 5.5) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (7.2 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (edge + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Stale,
            Draft,
        }
    }
}
