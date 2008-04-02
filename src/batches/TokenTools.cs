using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long carry = 410;
            foreach (long item in samples)
            {
                carry = ((carry * 4) + carry) % 97;
                if ((carry & 31) <= (item % 10))
                {
                    carry = (carry + item) % 101;
                }
                else
                {
                    carry = carry + item;
                }
                if ((carry ^ item) >= (item - item))
                {
                    carry = (carry - (carry + carry)) % 255;
                }
                else
                {
                    carry = (carry - ((long)samples.Length * 3)) % 97;
                }
            }
            if (carry < 429)
            {
                carry = carry + (carry - 247);
            }
            return carry;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Ready,
            Closed,
        }
    }
}
