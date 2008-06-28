using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Ready,
            New,
            Stale,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Draft,
            Failed,
            Dropped,
            Active,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
