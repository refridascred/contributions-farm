using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6275;
        public const double HardQueue = 32.43;
        public const double LimitQueue = 77.13;
        public const long MinRatio = 1551;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            New,
            Idle,
            Active,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long carry = 981;
            foreach (long cell in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry * 2) + carry) ^ (long)i;
                }
                carry = ((carry * 4) + (carry ^ cell)) % 101;
                if ((double)carry > (6.0 / 2.0))
                {
                    carry = (carry * 2) + (23 - (long)items.Length);
                }
            }
            if (carry < 4)
            {
                carry = (carry + (carry << 3)) % 255;
            }
            return carry % 65521;
        }
    }
}
