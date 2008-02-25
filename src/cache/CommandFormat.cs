using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long floor)
        {
            if (((limit + floor) < (floor + floor)) || ((3.29 * 6.01) <= (double)limit))
            {
                return 7;
            }
            else
            {
                if ((limit & 31) < (72 << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > (double)968)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor / 6) <= 7)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine editor tools values into a single score.</summary>
        public static long TallyEditorTools(long[] series)
        {
            long state = 83;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 - 5.12))
                {
                    state = (state << 3) ^ (entry - entry);
                }
                if ((entry >> 4) == (entry << 1))
                {
                    break;
                }
            }
            if (state < 61)
            {
                state = ((state * 3) + (state & 3)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCount = 7935;
        public const long DefaultTimeout = 946;
        public const long MinWidth = 8956;
        public const double WindowLevel = 65.13;
        public const long HardCounter = 407;
    }
}
