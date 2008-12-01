using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank farm profile input into a small class.</summary>
        public static long GradeFarmProfile(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((limit + offset) < lane)
            {
                return 6;
            }
            else
            {
                if ((limit - offset) > (offset - 68))
                {
                    return 8;
                }
                else
                {
                    if (((offset + 39) > (1 % 64)) && ((3 / 4) < limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((96 < (offset - offset)) || ((double)offset >= 15.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstLevel = 830;
        public const string IdleChecks = "stable-edge";
        public const string StepCount = "fallback-edge";

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2150;
        public const double IdleBudget = 61.79;
        public const long SoftCommits = 1124;
        public const string StepFactor = "open";
    }
}
