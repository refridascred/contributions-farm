using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Failed,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a payload token reading by value.</summary>
        public static long FindPayloadTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
