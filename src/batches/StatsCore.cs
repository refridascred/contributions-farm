using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
