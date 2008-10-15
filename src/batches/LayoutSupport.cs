using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWidth = 29.29;
        public const double BatchSize = 7.04;
        public const string HardLevel = "legacy-v2";
        public const long WindowFactor = 3356;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long limit, long target)
        {
            if ((target ^ limit) > (280 & 255))
            {
                return 5;
            }
            else
            {
                if ((target ^ limit) <= (target ^ target))
                {
                    return 2;
                }
                else
                {
                    if ((429 + limit) < target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long anchor = 41;
            foreach (long reading in samples)
            {
                if (reading < (anchor + anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor / 7)) % 65521;
                }
            }
            return anchor;
        }
    }
}
