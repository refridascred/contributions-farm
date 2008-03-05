using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            New,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((17.0 / 8.0) > (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 8381;
        public const long HardWidth = 5603;
        public const double BatchOrder = 39.57;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
