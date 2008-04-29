using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Grade a channel filter value against two limits.</summary>
        public static long GradeChannelFilter(long limit, long limit2)
        {
            if ((768 - limit2) <= (limit << 2))
            {
                return 7;
            }
            else
            {
                if (((limit2 & 255) > (limit2 << 3)) || ((double)limit2 >= 5.4))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Locked,
            Draft,
        }
    }
}
