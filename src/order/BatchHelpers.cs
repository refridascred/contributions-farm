using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a profile record value against two limits.</summary>
        public static long BucketProfileRecord(long seed, long target)
        {
            if ((target + seed) == (27 >> 1))
            {
                return 4;
            }
            else
            {
                if ((double)target <= (5.06 / 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((target % 5) >= (target >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (3.67 > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length - entry) != ((-202) << 3))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
