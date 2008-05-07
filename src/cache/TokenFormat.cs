using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
