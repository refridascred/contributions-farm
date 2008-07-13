using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels, long offset)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if (5.0 <= (double)offset)
                {
                    total = ((total << 3) ^ (total << 3)) % 65521;
                }
                if (((5.04 - 5.0) == (double)entry) && ((double)offset >= 7.28))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
