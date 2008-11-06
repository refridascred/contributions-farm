using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a profile payload pair into a bucket.</summary>
        public static long BucketProfilePayload(long bound, long step)
        {
            long cur = bound ^ step;
            if ((66 >= cur) && ((bound + step) >= (step - cur)))
            {
                return 8;
            }
            else
            {
                if ((step % 12) >= cur)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Idle,
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] samples)
        {
            long total = 73;
            foreach (long reading in samples)
            {
                total = (total - (reading / 7)) % 255;
                if ((double)reading > (15.0 - 6.2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
