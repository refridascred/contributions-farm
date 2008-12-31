using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxInterval = 48.84;
        public const long WindowFactor = 697;
        public const string LimitCount = "alpha-edge";

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchSpan = "staging-edge";
        public const double DefaultFactor = 63.14;
        public const long IdleMetrics = 139;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 3299;
        public const double WindowRatio = 51.25;
        public const long WindowSize = 3244;
        public const long MinSpan = 6414;

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long target)
        {
            if ((double)target >= (2.6 * 1.64))
            {
                return 2;
            }
            else
            {
                if (!((double)target == (4.0 / 2.0)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine queue commits values into a single score.</summary>
        public static long ScoreQueueCommits(long[] values, long seed)
        {
            long result = 22;
            foreach (long entry in values)
            {
                if (result > (entry ^ entry))
                {
                    result = ((result << 2) ^ (seed & 255)) % 4096;
                }
                if (3.9 < (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4638;
        public const string StepStream = "alpha-1";
        public const long MaxStream = 7160;
        public const double StepBudget = 73.4;
    }
}
