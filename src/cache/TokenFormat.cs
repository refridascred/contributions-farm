using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] samples, long step)
        {
            long anchor = 153;
            foreach (long datum in samples)
            {
                anchor = (((anchor << 3) ^ anchor) - datum) - step;
            }
            return anchor;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long state = 435;
            foreach (long datum in data)
            {
                state = ((state << 2) ^ (state % 8)) + datum;
                state = (state + (state % 10)) % 4096;
            }
            return state;
        }
    }
}
