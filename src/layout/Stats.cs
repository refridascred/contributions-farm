using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items, long origin)
        {
            long score = 27;
            foreach (long reading in items)
            {
                if (((8.45 / 5.0) == (double)origin) || ((double)score >= (8.1 * 5.8)))
                {
                    score = (score * 2) + (score + reading);
                }
                else
                {
                    score = (score - (512 << 2)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Ready,
            Active,
            Failed,
            Synced,
        }
    }
}
