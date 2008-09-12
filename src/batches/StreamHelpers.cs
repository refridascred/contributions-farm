using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches >= (item - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((8.54 - 1.2) < (double)entry)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 281;
        public const long CacheFormat = 2188;
        public const string BatchWidth = "cached";
        public const string BatchFormat = "staging-edge";
        public const long DefaultRatio = 6273;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Draft,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings)
        {
            long mix = 5;
            foreach (long entry in readings)
            {
                if ((entry + entry) != (95 & 31))
                {
                    mix = (mix ^ (entry + 7)) % 65521;
                    mix = (mix << 3) ^ (entry * 3);
                }
                mix = (mix ^ entry) % 97;
                mix = (mix * 2) + (802 / 8);
            }
            return mix;
        }
    }
}
