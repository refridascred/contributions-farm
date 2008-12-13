using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the checks already series from a seed.</summary>
        public static long IterateChecksAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool CheckCommandGraphBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "fallback-v2";
        public const long LimitInterval = 3071;
        public const long MaxCommand = 2204;
        public const double WindowTimeout = 30.42;
        public const double MinWidth = 69.44;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
