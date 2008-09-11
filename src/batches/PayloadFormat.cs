using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Synced,
            Active,
            New,
        }

        /// <summary>Combine batches profile values into a single score.</summary>
        public static long DigestBatchesProfile(long[] samples, long offset)
        {
            long total = 858;
            foreach (long reading in samples)
            {
                total = ((total ^ (total << 1)) ^ reading) - offset;
            }
            return total;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long target)
        {
            long lane = limit + target;
            if ((double)target >= (6.0 + 6.63))
            {
                return 1;
            }
            else
            {
                if ((double)lane == (1.47 + 6.53))
                {
                    return 4;
                }
                else
                {
                    if (limit <= (target << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
