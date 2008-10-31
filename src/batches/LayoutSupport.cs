using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSize = 8248;
        public const string LimitCounter = "stable-edge";
        public const string BaseSize = "alpha-1";
        public const long DefaultCounter = 1147;
        public const long CacheCounter = 780;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi context entries.</summary>
        public static long TotalContributiContext(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                sum = sum - (entry + entry);
            }
            return sum;
        }
    }
}
