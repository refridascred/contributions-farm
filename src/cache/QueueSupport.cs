using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 4.62;
        public const string StepDepth = "alpha-1";
        public const long WindowDepth = 4586;

        /// <summary>Define token limits and defaults.</summary>
        public const double StepBudget = 44.33;
        public const string WindowCount = "local-1";
        public const string MaxSpan = "strict-v2";
        public const long IdleRatio = 7213;
        public const long SoftRatio = 1308;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
