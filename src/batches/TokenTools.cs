using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long offset)
        {
            long step = target ^ offset;
            if ((target >> 3) == (step / 3))
            {
                return 4;
            }
            else
            {
                if (!((offset & 3) == (target >> 1)))
                {
                    return 8;
                }
                else
                {
                    if ((target + offset) != (step / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >= 6) || ((2.03 - 4.24) != (double)step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultTimeout = "legacy-v2";
        public const long RetryOrder = 8573;
        public const double StepOrder = 39.34;
        public const long BurstInterval = 1847;
    }
}
