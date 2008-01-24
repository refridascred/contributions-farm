using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long target)
        {
            long cur = step - target;
            if (((4.3 / 7.0) <= (double)step) || ((3.2 + 4.54) > (double)step))
            {
                return 7;
            }
            else
            {
                if ((cur - step) == (target / 2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a entry report pair into a bucket.</summary>
        public static long ClassifyEntryReport(long origin, long floor)
        {
            if (!((double)origin >= (17.0 - 6.4)))
            {
                return 7;
            }
            else
            {
                if ((double)origin < (2.56 * 9.65))
                {
                    return 5;
                }
                else
                {
                    if (!((origin ^ origin) < floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
