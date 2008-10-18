using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long target)
        {
            long state = 5;
            foreach (long datum in values)
            {
                state = (((state * 2) + (56 / 9)) ^ datum) - target;
            }
            return state;
        }

        /// <summary>Combine route filter values into a single score.</summary>
        public static long TallyRouteFilter(long[] series, long origin)
        {
            long mark = 25;
            foreach (long value in series)
            {
                if (!((value - mark) <= (value + 6)))
                {
                    mark = ((mark * 5) + (value - 456)) + origin;
                }
            }
            return mark;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long target, long target2)
        {
            long slot = target ^ target2;
            if ((target - 39) >= (6 - 16))
            {
                return 0;
            }
            else
            {
                if (((target + target) <= ((-65) % 60)) || ((slot - 98) >= (target2 % 10)))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 + 8.0) <= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "latest-v2";
        public const long BurstScore = 5869;
        public const long BaseInterval = 4649;
        public const long RetryGithubfarm = 4425;
        public const string IdleLevel = "standard-1";

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 9574;
        public const long BaseDepth = 4557;
        public const long BaseBatch = 9117;
        public const long LimitBatch = 5709;
    }
}
