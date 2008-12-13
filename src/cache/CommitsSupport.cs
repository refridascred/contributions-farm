using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of format already readings.</summary>
        public static long DigestFormatAlready(long[] samples, long origin)
        {
            long carry = 6;
            foreach (long datum in samples)
            {
                if ((14.0 / 6.0) >= (double)origin)
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry + (datum ^ 40)) % 1000;
                }
                if (((long)samples.Length - (long)samples.Length) >= datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Active,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Queued,
            Draft,
            New,
            Locked,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Synced,
            Idle,
            Dropped,
        }
    }
}
