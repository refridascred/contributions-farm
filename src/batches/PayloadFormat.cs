using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 35.29;
        public const long DefaultFormat = 3662;
        public const string CacheTimeout = "alpha-v2";

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Stale,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((6.9 + 4.5) <= (double)matches)
                {
                    matches = ((matches + 2) + value) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
