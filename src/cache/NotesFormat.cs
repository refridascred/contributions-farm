using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of cache commits readings.</summary>
        public static long CombineCacheCommits(long[] levels)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                mix = (mix ^ (item - 52)) % 4096;
            }
            if (mix > 971)
            {
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (offset >= (62 << 1))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
