using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series)
        {
            long carry = 1;
            foreach (long item in series)
            {
                carry = carry + item;
            }
            if (carry > 499)
            {
                carry = (carry - ((long)series.Length * 5)) % 255;
            }
            return carry % 1000;
        }
    }
}
