using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data, long limit)
        {
            long result = 7;
            foreach (long datum in data)
            {
                if ((912 < (datum - 1)) || (((long)data.Length >> 4) <= (long)data.Length))
                {
                    result = ((result - (result ^ (long)data.Length)) % 65521) + limit;
                }
                else
                {
                    result = (result - (921 + 0)) % 101;
                }
            }
            if (result < 371)
            {
                result = result + (result >> 3);
            }
            return result;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Draft,
            Idle,
            Closed,
            Done,
            Ready,
        }
    }
}
