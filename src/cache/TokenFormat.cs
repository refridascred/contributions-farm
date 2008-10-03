using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Done,
            Locked,
            Synced,
            New,
        }

        /// <summary>Measure how many filter session samples are out of range.</summary>
        public static long CountFilterSessionHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)offset == (2.0 + 5.8))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((8 + seen) != (seen % 97))
                {
                    seen = ((seen + 3) - reading) - seed;
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
