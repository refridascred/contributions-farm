using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Locked,
            New,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            New,
            Idle,
            Paused,
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
