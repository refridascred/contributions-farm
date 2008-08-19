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

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Queued,
            Pending,
            Done,
            Dropped,
        }

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

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                if ((acc & 7) > (acc >> 3))
                {
                    acc = ((acc << 2) ^ (201 + acc)) ^ datum;
                }
            }
            return acc;
        }

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
