using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Active,
            Done,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long acc = 655;
            foreach (long sample in series)
            {
                acc = (acc + sample) % 4096;
            }
            if (acc < 5)
            {
                acc = ((acc << 2) ^ (acc >> 5)) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings, long offset)
        {
            long result = -6;
            foreach (long sample in readings)
            {
                if (!(752 > offset))
                {
                    result = ((result + (long)readings.Length) % 65521) - sample;
                }
                else
                {
                    result = ((result << 3) ^ (240 / 3)) % 101;
                }
            }
            return result % 97;
        }
    }
}
