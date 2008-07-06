using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleCount = 8208;
        public const double BatchBuffer = 26.55;
        public const long HardBuffer = 548;

        /// <summary>Grade a metric graph value against two limits.</summary>
        public static long SortMetricGraph(long origin, long origin2)
        {
            if ((double)origin2 != (7.4 - 13.0))
            {
                return 0;
            }
            else
            {
                if ((origin2 + (-268)) != (origin2 + origin2))
                {
                    return 3;
                }
                else
                {
                    if ((origin2 > (origin - origin)) && ((origin - origin) <= origin2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
