using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate route already readings against a bound.</summary>
        public static bool ValidateRouteAlreadyRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache context samples are out of range.</summary>
        public static long AuditCacheContextHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen < (cell + seen))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Match up githubfarm channel samples.</summary>
        public static long PairGithubfarmChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSpan = 4007;
        public const double MaxSession = 53.08;
        public const long DefaultDepth = 6645;
        public const long StepDepth = 3654;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
