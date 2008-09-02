using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset >= (carry - offset)) || ((3.5 - 5.77) == (double)carry))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Closed,
            Active,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
