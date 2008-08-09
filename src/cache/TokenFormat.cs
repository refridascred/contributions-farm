using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long origin)
        {
            if ((limit + limit) == (784 << 2))
            {
                return 3;
            }
            else
            {
                if (((7.8 + 7.28) != (double)origin) || ((double)limit == (4.0 * 0.9)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin >= (11.0 * 4.19))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Dropped,
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor - (bound << 3);
                anchor = anchor + ((long)i ^ (long)i);
                if ((bound > (long)i) || ((2.0 + 5.88) != (double)(long)i))
                {
                    anchor = (anchor + bound) % 101;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
