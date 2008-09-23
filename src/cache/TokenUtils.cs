using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long offset)
        {
            if ((1.28 - 6.11) > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset % 2) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (53 > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepRatio = 77.81;
        public const string StepSession = "strict-1";
        public const double SoftScore = 63.25;
        public const long MaxSession = 4086;
    }
}
