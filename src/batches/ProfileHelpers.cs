using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseDepth = "staging-v2";
        public const long MinSession = 7138;
        public const long IdleWidth = 1050;
        public const double DefaultSession = 17.37;
        public const double WindowSession = 31.34;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 2) < (value * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long step, long offset)
        {
            if ((offset + offset) >= step)
            {
                return 7;
            }
            else
            {
                if ((offset >> 4) < 16)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset >= (8.4 - 5.36))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 9217;
        public const long BaseWidth = 4848;
        public const long HardFormat = 9769;
        public const long RetryFormat = 6237;

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6284;
        public const long MaxSpan = 9712;
        public const long BaseFactor = 9721;
        public const long BatchRatio = 5805;
    }
}
