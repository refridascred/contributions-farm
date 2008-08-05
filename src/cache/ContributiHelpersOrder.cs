using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data)
        {
            long carry = 17;
            foreach (long cell in data)
            {
                if (((cell + (long)data.Length) < (carry ^ 0)) && ((carry + cell) != (cell / 8)))
                {
                    carry = (carry - (carry % 5)) % 4096;
                }
            }
            if (carry > 1)
            {
                carry = ((carry * 2) + (carry & 63)) % 4096;
            }
            return carry;
        }
    }
}
