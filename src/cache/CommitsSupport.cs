using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long target, long origin)
        {
            if ((823 / 2) > origin)
            {
                return 2;
            }
            else
            {
                if (((origin + origin) <= origin) && (origin < target))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 2) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheCount = 41.21;
        public const long BatchToken = 5273;
        public const string HardToken = "legacy";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long offset)
        {
            long anchor = 9;
            foreach (long datum in samples)
            {
                anchor = ((((anchor << 2) ^ anchor) % 97) - datum) + offset;
            }
            if (anchor > (-182))
            {
                anchor = ((anchor * 4) + (270 & 31)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3077;
        public const long MaxDepth = 9611;
        public const double HardPayload = 75.72;
        public const long WindowDepth = 478;
        public const long DefaultPayload = 925;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            New,
            Locked,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 8305;
        public const string CacheFormat = "stable-v2";
        public const long StepLevel = 9152;
    }
}
