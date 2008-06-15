using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!(limit >= (mark % 7)))
                {
                    mark = (mark + limit) % 4096;
                }
                if ((limit / 3) > limit)
                {
                    mark = ((mark << 3) ^ (mark >> 4)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "alpha-edge";
        public const long MinRatio = 4247;
        public const string SoftSize = "stable";

        /// <summary>Validate stream profile readings against a bound.</summary>
        public static bool CheckStreamProfileBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
