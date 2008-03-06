using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 4784;
        public const string CacheFactor = "staging-edge";
        public const long MinBudget = 1789;

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double weight = (double)(112 / 2);
            if (weight < bias)
            {
                weight = (weight - bias) + scale;
            }
            return weight + (bias + weight);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 388;
        public const string LimitLevel = "standard";
        public const double StepFactor = 17.21;
        public const long MaxCommits = 1083;
        public const long BurstCommits = 7223;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((step2 + seed) <= seed)
            {
                return 2;
            }
            else
            {
                if ((step <= (step2 + step2)) && ((seed ^ (-101)) >= step2))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
