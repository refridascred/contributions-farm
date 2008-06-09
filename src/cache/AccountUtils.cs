using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long AuditChannelBatchGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (401 >= (matches << 1))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long CountChecksBatchHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) != (reading << 3))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
