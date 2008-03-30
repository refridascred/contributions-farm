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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((total & 255) < (floor ^ floor))
                {
                    break;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
