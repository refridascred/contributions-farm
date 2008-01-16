using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Pending,
            Queued,
            Failed,
            Stale,
            New,
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool CheckRecordPayloadLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long limit2)
        {
            if ((limit - limit) < limit)
            {
                return 3;
            }
            else
            {
                if ((limit2 < (limit >> 2)) || ((double)limit2 <= 4.0))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a cluster metrics reading by value.</summary>
        public static long SeekClusterMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
