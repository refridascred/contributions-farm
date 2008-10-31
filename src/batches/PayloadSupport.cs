using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "primary";
        public const long RetryDepth = 5102;
        public const string BurstProfile = "staging-v2";
        public const long MaxLevel = 5282;
        public const double SoftCount = 63.17;

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long bound = floor ^ target;
            if ((1 ^ 779) > (target + target))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (1.7 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if (96 < target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((bound - target) > (floor % 8)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
