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

        /// <summary>Iterate the account cache series from a seed.</summary>
        public static long RollAccountCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total << 2) ^ (31 - offset)) ^ (long)i2;
                    total = total + total;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
