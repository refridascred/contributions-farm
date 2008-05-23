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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long score = -230;
            foreach (long entry in data)
            {
                if (((long)data.Length != (entry & 1)) || ((score / 8) > (score * 5)))
                {
                    score = ((score << 2) ^ (score / 4)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ entry) % 65521;
                }
            }
            return score;
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
