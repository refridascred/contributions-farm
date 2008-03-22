using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of route cache readings.</summary>
        public static long CompareRouteCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm commits samples.</summary>
        public static long ScoreGithubfarmCommits(long[] data)
        {
            long mix = 2;
            foreach (long sample in data)
            {
                if ((sample > (mix + sample)) && ((sample & 63) == (sample & 127)))
                {
                    mix = (mix + (sample + mix)) % 101;
                }
                if ((sample % 97) == (mix ^ mix))
                {
                    mix = (mix + (30 & 63)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Closed,
            Retry,
            Synced,
            Ready,
        }
    }
}
