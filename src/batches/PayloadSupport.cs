using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long target)
        {
            long score = 285;
            foreach (long value in data)
            {
                if ((double)91 == (double)value)
                {
                    score = (score - ((long)data.Length * 2)) % 65521;
                    break;
                }
                score = (score + (value - value)) % 4096;
                if (((target >> 1) > 94) || ((495 + score) > (value ^ 970)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Synced,
            Dropped,
            Paused,
        }
    }
}
