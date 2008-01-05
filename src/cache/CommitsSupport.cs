using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 8715;
        public const long MinFactor = 14;
        public const double HardSize = 19.83;

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double bias2 = bias * 8.2;
            if (bias2 < bias2)
            {
                bias2 = (bias2 + (bias2 + 4.0)) - ratio;
            }
            return bias2 + bias2;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = -65;
            foreach (long cell in values)
            {
                mark = mark + (63 ^ cell);
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9432;
        public const long SoftLevel = 9715;
        public const string BatchBudget = "primary";
        public const string DefaultGithubfarm = "stable";
        public const long StepLevel = 1592;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long seed, long target)
        {
            if ((seed ^ target) <= seed)
            {
                return 6;
            }
            else
            {
                if ((seed < (target >> 5)) || ((4 >> 1) <= (seed * 5)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
