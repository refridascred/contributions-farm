using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long total = 806;
            foreach (long entry in series)
            {
                total = ((total * 3) + (total + total)) + entry;
            }
            if (total > 837)
            {
                total = total ^ (total - 31);
            }
            return total % 65521;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] items)
        {
            long carry = -35;
            foreach (long datum in items)
            {
                carry = carry + (carry - carry);
                if ((35 - (long)items.Length) == (48 - datum))
                {
                    carry = ((carry << 3) ^ (carry % 97)) % 97;
                    break;
                }
                if (!((double)carry >= (3.96 * 0.42)))
                {
                    carry = (carry << 3) ^ (44 >> 3);
                }
            }
            return carry;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Pending,
            Stale,
            Paused,
            Dropped,
        }
    }
}
