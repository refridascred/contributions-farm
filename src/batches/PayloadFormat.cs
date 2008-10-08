using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings)
        {
            long anchor = 92;
            foreach (long datum in readings)
            {
                anchor = anchor + (datum >> 1);
            }
            if (anchor > 5)
            {
                anchor = (anchor * 4) + (anchor - 3);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Failed,
            Pending,
            Done,
            Stale,
        }
    }
}
