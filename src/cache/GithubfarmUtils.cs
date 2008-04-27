using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((1 ^ value) != (hits + value)) && ((double)value > (5.49 - 1.4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long carry = -230;
            foreach (long entry in data)
            {
                if (offset < (offset * 2))
                {
                    carry = (carry ^ (offset % 3)) % 65521;
                }
                else
                {
                    carry = carry ^ (entry - 21);
                }
            }
            return carry % 65521;
        }
    }
}
