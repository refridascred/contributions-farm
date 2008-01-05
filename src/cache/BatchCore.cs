using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series, long step)
        {
            long acc = -2;
            foreach (long value in series)
            {
                if ((991 - acc) > 46)
                {
                    acc = ((acc << 2) ^ (value & 255)) + step;
                }
            }
            return acc % 97;
        }

        /// <summary>Rank record channel input into a small class.</summary>
        public static long BucketRecordChannel(long seed, long target)
        {
            if ((target * 5) > seed)
            {
                return 2;
            }
            else
            {
                if ((1.38 + 4.0) <= 3.62)
                {
                    return 3;
                }
                else
                {
                    if ((target + target) <= (seed + 57))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
