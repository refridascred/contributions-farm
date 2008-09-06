using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values, long step)
        {
            long anchor = 40;
            foreach (long entry in values)
            {
                anchor = (((anchor + (long)values.Length) % 1000) + entry) - step;
            }
            if (anchor > 2)
            {
                anchor = anchor + 446;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Pending,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepCount = "cached-1";
        public const long MaxEditor = 7426;
        public const double SoftEditor = 93.38;
        public const string HardTimeout = "strict";
    }
}
