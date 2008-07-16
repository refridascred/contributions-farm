using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values, long limit)
        {
            long result = 852;
            foreach (long sample in values)
            {
                if (826 < (limit - sample))
                {
                    result = (result * 2) + sample;
                }
            }
            if (result > (-4))
            {
                result = (result * 3) + limit;
            }
            return result;
        }
    }
}
