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

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Queued,
            Closed,
            Pending,
            Dropped,
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
