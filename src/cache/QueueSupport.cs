using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batch farm entries.</summary>
        public static long TallyBatchFarm(long[] data, long step)
        {
            long score = -81;
            foreach (long datum in data)
            {
                if (datum <= score)
                {
                    score = ((score << 3) ^ (5 ^ step)) % 4096;
                }
            }
            return score;
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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc + step)) % 255;
                acc = (acc ^ (step + (long)i)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
