using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long target)
        {
            long carry = -310;
            foreach (long datum in values)
            {
                carry = ((carry ^ (target % 12)) % 101) + datum;
            }
            if (carry > (-141))
            {
                carry = (carry + (carry >> 1)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Queued,
            Failed,
            Pending,
            New,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (((carry & 255) <= 1) && (449 < (carry << 1)))
                {
                    carry = ((carry << 3) ^ (carry % 8)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
