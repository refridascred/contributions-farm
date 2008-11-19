using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Draft,
            Synced,
            Closed,
        }
    }
}
