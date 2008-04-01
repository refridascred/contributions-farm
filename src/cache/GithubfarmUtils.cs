using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Ready,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
