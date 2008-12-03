using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool CheckBatchesChecksRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Check that every filter tools entry stays within the limit.</summary>
        public static bool VerifyFilterToolsLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
