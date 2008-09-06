using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long DigestQueueBuffer(long[] data, long seed)
        {
            long result = 1;
            foreach (long sample in data)
            {
                if (!((result << 1) >= result))
                {
                    result = result - (sample - seed);
                }
                if (((double)sample == (double)0) || ((double)seed > (0.59 + 20.0)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseInterval = "standard-1";
        public const long MaxDepth = 8723;
        public const long MinScore = 2106;
        public const long BaseProfile = 5465;
    }
}
