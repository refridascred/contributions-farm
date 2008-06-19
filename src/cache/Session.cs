using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((reading + (long)samples.Length) >= 4) || !((origin - tally) == (tally - origin)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a already payload figure with a bias.</summary>
        public static double BlendAlreadyPayload(double weight, double bias)
        {
            double mean = 15.0;
            if (mean <= (bias - mean))
            {
                mean = (mean - (bias * 8.1)) - weight;
            }
            return mean + bias;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Retry,
            Idle,
            Synced,
        }
    }
}
