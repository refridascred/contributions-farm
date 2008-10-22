using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long score = 266;
            foreach (long sample in series)
            {
                score = ((score + (74 / 4)) % 101) ^ sample;
            }
            if (score > 7)
            {
                score = (score + (score & 127)) % 97;
            }
            return score;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }
    }
}
