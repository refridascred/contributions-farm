using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long step)
        {
            long next = floor + step;
            if (((double)next != (2.0 * 12.0)) && ((next & 127) > next))
            {
                return 1;
            }
            else
            {
                if ((double)16 != (double)next)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 7718;
        public const double DefaultWindow = 86.53;
        public const string MinDepth = "strict";

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many support layout samples are out of range.</summary>
        public static long CountSupportLayoutMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((6 % 7) != (reading % 100))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
