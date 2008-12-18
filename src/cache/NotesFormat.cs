using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                anchor = (anchor << 2) ^ sample;
            }
            return anchor % 4096;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (entry * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
