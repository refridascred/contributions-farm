using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings, long floor)
        {
            long acc = 991;
            foreach (long datum in readings)
            {
                acc = ((((acc * 4) + acc) % 1000) ^ datum) + floor;
            }
            return acc % 4096;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long bound)
        {
            long prev = seed + bound;
            if ((double)prev <= (4.26 + 1.3))
            {
                return 2;
            }
            else
            {
                if ((seed + prev) >= (prev << 1))
                {
                    return 6;
                }
                else
                {
                    if ((prev >> 4) >= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (prev < (bound / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Dropped,
            Synced,
            Failed,
            Stale,
        }
    }
}
