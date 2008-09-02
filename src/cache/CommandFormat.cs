using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a schema command reading by value.</summary>
        public static long FindSchemaCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "staging-v2";
        public const string WindowBudget = "open-1";
        public const string SoftSize = "standard";

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            long diff = floor ^ target;
            if (((target - floor) != (diff + diff)) || ((double)diff == (9.95 * 4.0)))
            {
                return 4;
            }
            else
            {
                if ((diff <= (diff ^ 0)) || (85 <= (floor - diff)))
                {
                    return 6;
                }
                else
                {
                    if ((801 ^ diff) < target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
