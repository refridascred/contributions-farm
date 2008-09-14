using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - (-975)) <= (count / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Pending,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Stale,
            Paused,
        }
    }
}
