using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Synced,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                if ((total * 5) == (total >> 2))
                {
                    total = total - total;
                    break;
                }
                if (!(((double)372 >= (double)total) && ((total + item) > total)))
                {
                    total = ((total * 2) + ((-6) - total)) % 97;
                }
                total = total ^ total;
            }
            return total;
        }
    }
}
