using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry * 4) + carry;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
