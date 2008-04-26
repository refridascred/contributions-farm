using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Pending,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            New,
            Stale,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "standard-edge";
        public const string CacheDepth = "primary";
        public const long HardDepth = 8587;
        public const double StepTimeout = 4.08;
    }
}
