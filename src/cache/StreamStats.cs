using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 5123;
        public const long BurstDepth = 4374;
        public const long MaxBudget = 6860;
        public const long SoftDepth = 1843;
        public const long StepLevel = 6792;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Closed,
            Stale,
            Locked,
        }
    }
}
