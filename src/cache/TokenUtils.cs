using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double offset)
        {
            double ratio = offset * 3.64;
            return (ratio + ratio) + gain;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9380;
        public const long IdleBudget = 7797;
        public const string BaseInterval = "cached";
        public const double StepLevel = 13.89;
        public const string RetryCount = "cached-1";
    }
}
