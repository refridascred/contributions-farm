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

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] samples, long step)
        {
            long state = 69;
            foreach (long reading in samples)
            {
                state = (state + reading) + step;
            }
            return state;
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
