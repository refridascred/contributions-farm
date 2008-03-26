using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double StepSize = 12.32;
        public const long DefaultCommand = 1054;
        public const long BatchCommand = 3097;
        public const string IdleLevel = "strict-1";
        public const long BaseCommand = 713;

        /// <summary>Rank farm report input into a small class.</summary>
        public static long BucketFarmReport(long step, long origin)
        {
            long next = step + origin;
            if ((origin % 2) != (next >> 5))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) > step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count format checks pairs that satisfy a relation.</summary>
        public static long OverlapFormatChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
