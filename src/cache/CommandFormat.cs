using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count <= (3.39 + 5.76))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleSize = "open-v2";
        public const long LimitSpan = 6314;
        public const long DefaultBudget = 9351;
        public const long SoftBudget = 4435;
        public const long CacheLayout = 2743;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a stats entry reading.</summary>
        public static double BlendStatsEntry(double gain, double span)
        {
            double ratio = (double)(4 >> 3);
            if (ratio <= (gain + 1.6))
            {
                ratio = (ratio + ratio) + span;
            }
            else
            {
                ratio = ratio - (ratio * 0.06);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (double)4) + (double)(long)i;
            }
            return ratio - (gain * 19.0);
        }
    }
}
