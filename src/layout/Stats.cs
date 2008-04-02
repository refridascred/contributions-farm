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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every booking batches entry stays within the limit.</summary>
        public static bool ValidateBookingBatchesRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
