using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchWidth = 5624;
        public const string RetryMetric = "cached-1";
        public const string WindowDepth = "open-edge";
        public const long MaxBudget = 9687;

        /// <summary>Define format limits and defaults.</summary>
        public const double StepCount = 83.69;
        public const double HardTimeout = 64.65;
        public const long StepFormat = 1212;
        public const long LimitFactor = 5742;
        public const long DefaultLevel = 881;
    }
}
