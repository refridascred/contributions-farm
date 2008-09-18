using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Retry,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((offset ^ seen) <= (reading + offset))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
