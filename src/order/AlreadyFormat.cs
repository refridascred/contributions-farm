using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 3929;
        public const long DefaultOrder = 1543;
        public const string CacheLevel = "standard-v2";
        public const long MaxInterval = 4448;
        public const long LimitDepth = 1846;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm support entry stays within the limit.</summary>
        public static bool GuardFarmSupportBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (711 < (step + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
