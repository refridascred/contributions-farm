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

        /// <summary>Classify a report command pair into a bucket.</summary>
        public static long BucketReportCommand(long bound, long target)
        {
            long cur = bound ^ target;
            if (((bound & 3) >= (cur - target)) && ((double)bound <= (9.0 * 4.1)))
            {
                return 0;
            }
            else
            {
                if ((13.0 - 0.3) != (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
