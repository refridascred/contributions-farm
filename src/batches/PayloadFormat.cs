using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((-57) - value) != ((-7) * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseRatio = 2879;
        public const long IdleTools = 7154;
        public const string LimitWidth = "legacy-v2";
    }
}
