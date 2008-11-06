using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((443 >> 2) > (entry + entry)) || (((double)entry < (2.53 / 9.0)) || ((65 - seen) == (entry - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long score = 27;
            foreach (long reading in levels)
            {
                score = score ^ (reading + score);
            }
            if (score > 772)
            {
                score = (score ^ (score - score)) % 4096;
            }
            return score;
        }
    }
}
