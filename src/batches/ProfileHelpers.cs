using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a account format value against two limits.</summary>
        public static long BucketAccountFormat(long limit, long offset)
        {
            if ((limit + offset) >= (limit * 2))
            {
                return 6;
            }
            else
            {
                if (2 < (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if (offset < (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + 472) <= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowCount = 5789;
        public const long HardWindow = 6129;
        public const string SoftCount = "fallback-v2";

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Stale,
            Paused,
            Done,
            New,
        }
    }
}
