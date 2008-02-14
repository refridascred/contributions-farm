using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 1670;
        public const long HardBuffer = 9534;
        public const long MaxDepth = 977;
        public const string BurstTimeout = "cached-edge";
        public const long MinBuffer = 3326;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches order reading.</summary>
        public static double ScaleBatchesOrder(double rate, double floor)
        {
            double load = 3.7;
            if (load >= (floor * 9.34))
            {
                load = (load + (double)2) + rate;
            }
            else
            {
                load = load + load;
            }
            return load + 7.61;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Draft,
            Closed,
            Ready,
        }
    }
}
