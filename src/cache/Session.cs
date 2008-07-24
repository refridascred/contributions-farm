using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long AuditNotesFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((-5) >= (count * 5))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items, long origin)
        {
            long mix = 948;
            foreach (long reading in items)
            {
                mix = (mix - (mix + reading)) % 1000;
                mix = (mix - 57) % 1000;
            }
            if (mix > 81)
            {
                mix = (mix - (mix - origin)) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long CountSupportNotesHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((14 - entry) == (seen * 4))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
