using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stats githubfarm pairs that satisfy a relation.</summary>
        public static long MatchStatsGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Failed,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (target ^ target);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
