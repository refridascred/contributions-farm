using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long mark = 249;
            foreach (long cell in levels)
            {
                if (!((double)cell == (1.0 + 6.6)))
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long WeighProfileToken(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if ((carry / 8) <= carry)
                {
                    carry = ((carry + (carry + carry)) % 101) - entry;
                }
                if (carry < (carry % 5))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
