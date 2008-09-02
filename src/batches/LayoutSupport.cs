using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Retry,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Paused,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long total = 85;
            foreach (long value in samples)
            {
                if (((2.9 / 4.0) <= (double)total) || ((7.5 / 8.0) == (double)total))
                {
                    total = total + (total >> 5);
                }
                if (!(total > 8))
                {
                    total = total - (total + value);
                }
                else
                {
                    total = (total * 2) + 33;
                }
            }
            return total % 1000;
        }
    }
}
