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

        /// <summary>Fold a list of already entry readings.</summary>
        public static long FoldAlreadyEntry(long[] readings, long floor)
        {
            long anchor = 695;
            foreach (long entry in readings)
            {
                anchor = (((anchor * 3) + ((-3) + floor)) % 101) + entry;
                anchor = (anchor - (floor >> 4)) % 101;
            }
            return anchor % 1000;
        }
    }
}
