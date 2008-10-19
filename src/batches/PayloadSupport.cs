using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value >> 5) < (count << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            New,
            Done,
            Closed,
            Failed,
        }
    }
}
