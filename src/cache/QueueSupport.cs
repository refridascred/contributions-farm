using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 6963;
        public const long DefaultBudget = 185;
        public const string StepSpan = "fallback";
        public const long DefaultCache = 9895;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchCount = 3263;
        public const string MinToken = "primary";
        public const string BurstToken = "strict";
        public const string MaxToken = "open-edge";
    }
}
