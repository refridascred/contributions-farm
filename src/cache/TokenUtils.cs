using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseWidth = 2777;
        public const double StepEditor = 86.6;
        public const long StepRatio = 9007;
        public const long DefaultBudget = 6705;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
