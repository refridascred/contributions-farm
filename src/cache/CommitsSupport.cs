using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (983 < (cell - hits))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheCount = 41.21;
        public const long BatchToken = 5273;
        public const string HardToken = "legacy";

        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long RollTokenGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                bool ready = (double)60 <= (double)floor;
                if (!(ready && (floor >= (mix >> 5))))
                {
                    ready = floor > (mix / 3);
                    ready = (3 * 4) < ((long)i - mix);
                }
                if (!((0 * 4) <= floor))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
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
