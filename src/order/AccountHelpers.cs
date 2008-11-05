using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (weight + bias)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metric token samples.</summary>
        public static long MatchMetricTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit entry farm readings against a rule.</summary>
        public static long CountEntryFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)97)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
