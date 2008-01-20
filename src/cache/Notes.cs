using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Synced,
            Idle,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long bound, long target)
        {
            long edge = bound - target;
            if ((double)target < (9.98 * 8.63))
            {
                return 1;
            }
            else
            {
                if ((edge % 8) != (bound & 255))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Ready,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Combine metric record values into a single score.</summary>
        public static long CombineMetricRecord(long[] levels)
        {
            long carry = 945;
            foreach (long sample in levels)
            {
                carry = (carry ^ (carry / 8)) % 65521;
                if ((2.0 + 0.7) == (double)sample)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
