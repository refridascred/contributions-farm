using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long carry = 71;
            foreach (long item in series)
            {
                if ((item & 127) < (item << 3))
                {
                    carry = carry ^ (44 + item);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Paused,
            Idle,
            Failed,
            New,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (7 << 1))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
