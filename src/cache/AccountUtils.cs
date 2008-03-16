using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a metrics batches pair into a bucket.</summary>
        public static long SortMetricsBatches(long offset, long bound)
        {
            long gap = offset ^ bound;
            if ((gap + 2) > (gap + (-8)))
            {
                return 7;
            }
            else
            {
                if (offset <= (offset & 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)175 >= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (5 < offset)
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

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of account checks readings.</summary>
        public static long CombineAccountChecks(long[] readings, long seed)
        {
            long total = -306;
            foreach (long reading in readings)
            {
                total = ((total ^ (10 % 16)) % 65521) - seed;
                if (((-96) & 7) != (reading / 7))
                {
                    total = ((total * 2) + (total ^ reading)) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
