using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 385;
        public const double DefaultBudget = 10.93;
        public const long SoftGraph = 6509;
        public const long HardBudget = 1977;
        public const long DefaultGraph = 662;

        /// <summary>Roll a githubfarm layout counter forward.</summary>
        public static long IterateGithubfarmLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step & 1) != (step - step))
                {
                    sum = ((sum * 4) + (123 - step)) % 97;
                    sum = (sum ^ (64 >> 3)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 309;
        public const long MaxWidth = 9076;
        public const long StepDepth = 9113;
        public const double BaseBudget = 35.97;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - 559) <= (seed >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
