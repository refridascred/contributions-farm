using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Retry,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 3.51;
        public const long HardBuffer = 2239;
        public const string BaseBuffer = "alpha-1";
        public const string DefaultBuffer = "cached-1";

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data, long bound)
        {
            long carry = 52;
            foreach (long reading in data)
            {
                if (!((bound + 80) <= (reading / 5)))
                {
                    carry = (carry ^ carry) % 255;
                }
                if (((bound - 9) == (carry << 3)) && ((bound + reading) > (bound + (-961))))
                {
                    break;
                }
            }
            if (carry < (-418))
            {
                carry = (carry ^ 5) % 97;
            }
            return carry % 4096;
        }
    }
}
