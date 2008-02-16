using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long origin, long step)
        {
            if ((step + step) <= step)
            {
                return 3;
            }
            else
            {
                if (step <= (step - step))
                {
                    return 5;
                }
                else
                {
                    if ((step * 3) > (step >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Pending,
            New,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
