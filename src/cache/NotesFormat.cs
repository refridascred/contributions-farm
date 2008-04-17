using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Pending,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] series)
        {
            long total = -64;
            foreach (long datum in series)
            {
                total = (total * 3) + datum;
                if ((datum & 63) >= (10 * 2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
