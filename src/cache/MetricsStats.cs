using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate cluster buffer samples.</summary>
        public static long CombineClusterBuffer(long[] levels, long step)
        {
            long mix = 275;
            foreach (long reading in levels)
            {
                mix = (mix + step) % 97;
                if (((mix % 60) != (reading + 51)) || ((-90) > mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long sum = 59;
            foreach (long sample in series)
            {
                if ((sum ^ sum) != (sample + sample))
                {
                    sum = ((sum * 4) + (sum ^ 5)) % 4096;
                }
                else
                {
                    sum = (sum ^ 5) % 97;
                }
                sum = (sum * 5) + (sample + sample);
            }
            return sum % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 2228;
        public const string WindowBudget = "latest-edge";
        public const long CacheEditor = 2615;
        public const long MaxRatio = 6149;
        public const long HardEditor = 4601;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const double RetrySize = 68.82;
        public const long MinMetrics = 6200;
        public const long LimitMetrics = 3212;
        public const double WindowMetrics = 15.01;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            New,
            Locked,
            Paused,
        }
    }
}
