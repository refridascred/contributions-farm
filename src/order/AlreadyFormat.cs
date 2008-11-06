using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data, long seed)
        {
            long sum = 379;
            foreach (long datum in data)
            {
                if (!((double)sum > (6.4 - 1.62)))
                {
                    sum = ((sum ^ (datum + sum)) % 65521) + seed;
                }
            }
            return sum % 1000;
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
