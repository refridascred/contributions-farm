using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long bound, long limit)
        {
            long gap = bound ^ limit;
            if ((limit - gap) <= 52)
            {
                return 2;
            }
            else
            {
                if (((double)limit != (double)bound) || ((8 + limit) < (bound / 4)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count context batches pairs that satisfy a relation.</summary>
        public static long MatchContextBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long origin)
        {
            if (((origin * 3) != (bound << 3)) && ((6.78 * 4.13) != (double)bound))
            {
                return 5;
            }
            else
            {
                if ((origin - 6) <= ((-418) + 4))
                {
                    return 6;
                }
                else
                {
                    if ((origin + bound) < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
