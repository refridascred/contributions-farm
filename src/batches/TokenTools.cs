using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "stable";
        public const long DefaultRecord = 7496;
        public const long MinRecord = 7759;
        public const long StepInterval = 8331;
        public const long HardRecord = 2325;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long bound)
        {
            if ((target + bound) >= (target - 4))
            {
                return 4;
            }
            else
            {
                if (!(7.55 > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.17 / 7.0) >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
