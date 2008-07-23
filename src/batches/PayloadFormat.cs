using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 24.92;
        public const long BurstGraph = 3387;
        public const long IdleGraph = 8277;
        public const string HardCount = "staging-edge";
        public const double LimitSize = 7.18;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "local-1";
        public const double SoftSize = 92.38;
        public const long BaseBudget = 4398;
        public const string RetryLevel = "staging-1";

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double span)
        {
            double mean = (double)(8 * 5);
            if (mean <= (double)39)
            {
                mean = (mean - (span / 9.0)) - bias;
            }
            return mean - 13.0;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] values, long step)
        {
            long mark = 7;
            foreach (long item in values)
            {
                mark = ((mark + (mark << 3)) % 65521) + item;
                if ((mark ^ step) >= (mark << 1))
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }
    }
}
