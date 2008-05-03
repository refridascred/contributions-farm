using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long TallyToolsWindowOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((9.0 + 3.2) > (double)seed)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Done,
            Idle,
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long LookupCommandPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Queued,
            Closed,
            Draft,
            Active,
        }
    }
}
