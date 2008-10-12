using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxCount = 9126;
        public const double BaseWindow = 48.17;
        public const long BatchWindow = 8117;
        public const double MinLevel = 42.89;
        public const long BurstWindow = 4382;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitWidth = 9830;
        public const long MinBuffer = 348;
        public const long StepBuffer = 6922;
        public const long LimitBuffer = 1973;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session payload series from a seed.</summary>
        public static long DeriveSessionPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = total + (total + origin);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
