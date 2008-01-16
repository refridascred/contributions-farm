using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Failed,
            Draft,
            Synced,
            Active,
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

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Failed,
            Active,
            Done,
            Locked,
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

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] series, long limit)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                carry = (carry ^ (34 + 4)) % 101;
                if ((limit >= (carry / 3)) && (limit <= (cell & 7)))
                {
                    carry = ((carry << 3) ^ (carry % 12)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
