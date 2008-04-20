using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardRatio = 7533;
        public const long HardSize = 2842;
        public const double LimitSize = 85.57;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSize = 935;
        public const long SoftBudget = 9621;
        public const long BaseRatio = 6877;
        public const string StepRatio = "open-edge";
        public const long BurstFactor = 3189;
    }
}
