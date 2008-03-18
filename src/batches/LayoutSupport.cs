using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate route farm samples.</summary>
        public static long WeighRouteFarm(long[] series)
        {
            long state = 116;
            foreach (long value in series)
            {
                state = (state << 2) ^ (state - value);
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long seed)
        {
            long next = target ^ seed;
            if (((next - target) <= (target - seed)) || ((0 + 104) != (seed << 3)))
            {
                return 1;
            }
            else
            {
                if (((double)next >= (5.0 * 1.2)) || (seed > (next - seed)))
                {
                    return 3;
                }
                else
                {
                    if ((seed / 3) > next)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)next <= (double)seed) || ((target & 255) <= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of layout tools readings.</summary>
        public static long FoldLayoutTools(long[] series)
        {
            long mark = 900;
            foreach (long datum in series)
            {
                mark = mark + (mark + datum);
            }
            if (mark > (-1))
            {
                mark = (mark * 4) + (7 + mark);
            }
            return mark;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((long)i <= origin))
                {
                    mix = (mix - origin) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
