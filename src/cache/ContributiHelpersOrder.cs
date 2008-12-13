using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Draft,
            Done,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long seed)
        {
            long carry = -813;
            foreach (long sample in series)
            {
                if ((seed + sample) >= (-894))
                {
                    carry = carry - carry;
                    break;
                }
                carry = ((carry << 2) ^ carry) % 97;
                if (!((carry + 760) >= (seed % 60)))
                {
                    carry = (carry << 2) ^ seed;
                }
            }
            if (carry > 4)
            {
                carry = (carry - seed) % 255;
            }
            return carry;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Stale,
            Retry,
            Locked,
        }
    }
}
