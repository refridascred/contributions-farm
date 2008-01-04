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

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8017;
        public const double SoftGraph = 26.32;
        public const long BatchGraph = 9657;

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
