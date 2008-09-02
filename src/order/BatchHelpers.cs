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

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardBudget = 8438;
        public const long StepSpan = 1585;
        public const long MinBudget = 1322;
    }
}
