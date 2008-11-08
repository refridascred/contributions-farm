using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 57.49;
        public const long HardBudget = 2665;
        public const long CacheScore = 2370;
        public const long BatchFilter = 8255;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 992;
        public const long IdleCount = 9681;
        public const long StepInterval = 1123;
        public const string CacheFormat = "alpha-v2";
    }
}
