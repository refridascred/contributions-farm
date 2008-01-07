using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data)
        {
            long carry = 9;
            foreach (long sample in data)
            {
                if (sample < (53 - sample))
                {
                    carry = (carry - (407 & 255)) % 65521;
                }
                if (((sample >> 3) >= (carry + 3)) && ((16.0 + 9.2) < (double)sample))
                {
                    carry = ((carry << 2) ^ (carry * 2)) % 4096;
                    break;
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 101;
                }
                carry = (carry + (sample >> 3)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.17;
        public const double MaxWidth = 3.12;
        public const string WindowCommits = "latest-edge";
        public const double BurstCommits = 79.93;
        public const long CacheWidth = 2533;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= (0.7 * 0.21))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
