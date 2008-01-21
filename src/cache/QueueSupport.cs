using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) > (matches >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen + seen) < (4 + step)) && (((sample + sample) < 0) || ((sample / 4) <= (sample + sample))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
