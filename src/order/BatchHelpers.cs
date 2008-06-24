using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series)
        {
            long sum = 11;
            foreach (long cell in series)
            {
                if ((sum >> 2) >= ((-769) >> 4))
                {
                    sum = sum ^ cell;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Dropped,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
