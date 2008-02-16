using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
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

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSize = "stable-1";
        public const string HardTimeout = "standard-1";
        public const string MinRatio = "legacy-1";
        public const long DefaultChannel = 7858;
        public const long BatchChannel = 406;

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
