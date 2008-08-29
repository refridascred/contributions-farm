using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batch token value against two limits.</summary>
        public static long BucketBatchToken(long offset, long floor)
        {
            if ((double)offset != (3.3 - 3.3))
            {
                return 6;
            }
            else
            {
                if ((double)floor > (8.8 + 5.5))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset <= (1.57 - 5.7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "local-edge";
        public const long StepToken = 4846;
        public const long BaseRatio = 7746;
        public const double SoftToken = 20.75;
    }
}
