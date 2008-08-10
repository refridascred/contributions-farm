using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchRatio = 2845;
        public const string CacheAlready = "cached-edge";
        public const long RetryInterval = 1014;
        public const double WindowWidth = 44.83;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 1166;
        public const long BatchFormat = 8534;
        public const long SoftDepth = 3969;

        /// <summary>Classify a contributi notes pair into a bucket.</summary>
        public static long RankContributiNotes(long bound, long step)
        {
            if ((5 << 3) > (step ^ bound))
            {
                return 5;
            }
            else
            {
                if ((bound & 127) <= 734)
                {
                    return 1;
                }
                else
                {
                    if ((2 / 5) <= (bound - 0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
