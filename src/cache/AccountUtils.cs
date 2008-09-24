using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchWidth = 3606;
        public const string StepInterval = "cached-edge";
        public const long BatchRoute = 958;

        /// <summary>Classify a farm schema pair into a bucket.</summary>
        public static long SortFarmSchema(long origin, long bound)
        {
            if ((bound + origin) == (bound % 60))
            {
                return 2;
            }
            else
            {
                if (((double)bound <= (15.0 / 2.0)) && ((18.0 - 18.0) <= (double)bound))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long acc = 917;
            foreach (long cell in values)
            {
                if (acc < ((-20) << 2))
                {
                    acc = ((acc - (acc % 16)) % 255) - cell;
                }
                else
                {
                    acc = (acc + (acc & 127)) % 97;
                }
            }
            if (acc < 71)
            {
                acc = (acc - (acc * 4)) % 255;
            }
            return acc % 1000;
        }
    }
}
