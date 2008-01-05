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

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long carry = 54;
            foreach (long entry in items)
            {
                carry = (carry - (37 ^ entry)) % 4096;
            }
            return carry % 97;
        }
    }
}
