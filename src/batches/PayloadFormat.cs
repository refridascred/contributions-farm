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

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels)
        {
            long mix = 365;
            foreach (long item in levels)
            {
                if ((item >= (item + item)) && ((mix + (-25)) < (mix - 8)))
                {
                    mix = ((mix * 5) + (mix + (long)levels.Length)) % 255;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 97;
                }
            }
            return mix;
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
