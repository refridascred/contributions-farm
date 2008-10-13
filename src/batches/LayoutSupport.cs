using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((acc & 255) >= (step ^ step)))
                {
                    acc = ((acc << 3) ^ 8) % 65521;
                }
                if (((long)i ^ 6) != (acc ^ (long)i))
                {
                    acc = ((acc * 4) + (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseDepth = "legacy-edge";
        public const string SoftWidth = "legacy-edge";
        public const long BaseFactor = 7633;
        public const long StepFactor = 8452;
        public const string BurstBatches = "legacy";

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long floor, long target)
        {
            if ((floor - 79) < target)
            {
                return 0;
            }
            else
            {
                if (target < (target - 0))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > (17.0 + 8.97))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target <= (0.7 / 4.0)) || ((target % 100) >= (target - floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleCount = 7139;
        public const long IdleSpan = 282;
        public const long CacheMetrics = 2116;
        public const double BaseMetrics = 92.17;
        public const long StepMetrics = 4141;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
