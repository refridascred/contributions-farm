using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate graph contributi samples.</summary>
        public static long FoldGraphContributi(long[] series, long origin)
        {
            long carry = 840;
            foreach (long entry in series)
            {
                carry = carry ^ (carry * 4);
                if ((origin <= entry) && (((-386) >> 4) < origin))
                {
                    carry = ((carry * 2) + entry) % 1000;
                }
                else
                {
                    carry = (carry + entry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Active,
            Synced,
            Done,
        }
    }
}
