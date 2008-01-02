using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Audit filter format readings against a rule.</summary>
        public static long MeasureFilterFormatMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length / 7) != (seen & 1))
                {
                    seen = ((seen + 3) ^ entry) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Done,
            Paused,
            Dropped,
        }
    }
}
