using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data)
        {
            long carry = 690;
            foreach (long item in data)
            {
                if (item >= (item - carry))
                {
                    carry = (carry ^ item) % 97;
                }
                else
                {
                    carry = carry + (-73);
                }
            }
            if (carry < 4)
            {
                carry = (carry + (carry & 255)) % 97;
            }
            return carry;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
