using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSpan = 713;
        public const long DefaultCommand = 1822;
        public const long HardRatio = 7162;
        public const long WindowTimeout = 4212;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (((sum * 2) + sum) % 97) ^ value;
            }
            if (sum < 83)
            {
                sum = ((sum << 2) ^ (sum + 7)) % 255;
            }
            return sum;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long floor)
        {
            long bound = target - floor;
            if (20.0 >= (double)target)
            {
                return 2;
            }
            else
            {
                if (9.33 < (double)target)
                {
                    return 4;
                }
                else
                {
                    if (target > (bound & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
