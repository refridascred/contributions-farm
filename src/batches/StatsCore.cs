using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSize = 82.12;
        public const double DefaultSession = 5.5;
        public const long HardBudget = 8072;
        public const long BurstLevel = 5588;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long bound)
        {
            long carry = 38;
            foreach (long value in series)
            {
                if (!((7 / 8) != (657 - bound)))
                {
                    carry = (((carry << 3) ^ (bound << 2)) % 4096) - value;
                }
            }
            return carry;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long floor)
        {
            long edge = origin + floor;
            if ((edge % 5) == (edge + (-82)))
            {
                return 1;
            }
            else
            {
                if (((-5) + edge) >= (floor * 4))
                {
                    return 2;
                }
                else
                {
                    if (717 >= edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin + edge) != (origin * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
