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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            long next = step ^ seed;
            if ((962 ^ 783) > (next % 2))
            {
                return 5;
            }
            else
            {
                if (((8 << 1) != (step * 2)) && (seed >= (step / 3)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(((double)(long)values.Length != (1.0 * 11.0)) || ((matches ^ matches) <= (4 + reading))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
