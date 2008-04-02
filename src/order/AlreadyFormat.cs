using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long bound)
        {
            if ((bound + origin) != (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if ((316 >> 1) >= (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if (((5.0 * 20.0) > (double)origin) || ((double)origin <= (8.5 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
