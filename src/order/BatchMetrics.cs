using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark << 3) ^ (step + 53)) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 5140;
        public const double IdleLevel = 5.89;
        public const double MinRoute = 20.12;
        public const long BaseRoute = 3811;
        public const double StepSpan = 45.1;

        /// <summary>Grade a commits editor value against two limits.</summary>
        public static long SortCommitsEditor(long target, long floor)
        {
            long slot = target - floor;
            if ((target & 7) == (16 >> 3))
            {
                return 1;
            }
            else
            {
                if ((slot < floor) || (target <= (target * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long origin)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                if ((5.73 * 6.5) >= (double)cell)
                {
                    state = (((state << 2) ^ (state - cell)) % 1000) - origin;
                }
                if ((double)cell >= 9.54)
                {
                    state = state ^ 403;
                }
                else
                {
                    state = state - (state - cell);
                }
            }
            return state;
        }
    }
}
