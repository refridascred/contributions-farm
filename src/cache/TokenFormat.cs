using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "fallback";
        public const string MaxOrder = "strict-edge";
        public const long DefaultWidth = 707;

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long step, long target)
        {
            if (!((target % 3) <= target))
            {
                return 0;
            }
            else
            {
                if ((step - step) <= (target + 83))
                {
                    return 3;
                }
                else
                {
                    if (target >= (step >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
