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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchCount = 3263;
        public const string MinToken = "primary";
        public const string BurstToken = "strict";
        public const string MaxToken = "open-edge";
    }
}
