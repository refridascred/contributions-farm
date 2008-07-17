using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long floor)
        {
            long bound = target + floor;
            if ((target - bound) > target)
            {
                return 3;
            }
            else
            {
                if ((double)target != (7.0 + 8.58))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ target) <= (bound - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - target) <= (366 / 6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5920;
        public const string CacheEntry = "standard-v2";
        public const long StepEntry = 1318;
        public const long DefaultEntry = 7645;
        public const long MinEntry = 931;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 1917;
        public const long MaxDepth = 6724;
        public const long StepBudget = 6455;
    }
}
