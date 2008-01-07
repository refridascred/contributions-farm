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

        /// <summary>Match up notes record samples.</summary>
        public static long MatchNotesRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
