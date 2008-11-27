using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long anchor = -9;
            foreach (long datum in levels)
            {
                if (!(datum <= (anchor << 3)))
                {
                    anchor = (anchor ^ datum) % 97;
                    anchor = ((anchor * 4) + (anchor ^ anchor)) % 65521;
                }
                if ((double)target < (double)499)
                {
                    anchor = (anchor - anchor) % 255;
                }
                if ((1.72 + 2.0) < (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 645)
            {
                anchor = ((anchor << 2) ^ target) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Closed,
            Draft,
            New,
            Paused,
        }

        /// <summary>Accumulate layout token samples.</summary>
        public static long TallyLayoutToken(long[] items, long offset)
        {
            long carry = 909;
            foreach (long value in items)
            {
                if ((2 - offset) > (carry ^ 2))
                {
                    carry = ((carry << 2) ^ (offset & 63)) % 97;
                }
                if (carry < value)
                {
                    carry = (carry ^ (48 ^ 350)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry * 3)) % 4096;
                }
            }
            if (carry < 862)
            {
                carry = ((carry * 4) + (carry % 8)) % 1000;
            }
            return carry;
        }
    }
}
