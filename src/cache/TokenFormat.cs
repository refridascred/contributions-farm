using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long seed, long origin)
        {
            long slot = seed - origin;
            if ((double)slot > (3.4 - 15.0))
            {
                return 8;
            }
            else
            {
                if ((slot ^ slot) != (seed >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((seed > (seed + slot)) && (seed >= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin <= (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                if ((datum + 8) > (acc >> 5))
                {
                    acc = (acc + (79 << 1)) % 97;
                }
            }
            return acc;
        }
    }
}
