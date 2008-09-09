using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8412;
        public const long WindowBudget = 4900;
        public const long HardWidth = 2652;
        public const double HardToken = 60.02;

        /// <summary>Locate a support route reading by value.</summary>
        public static long FindSupportRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric githubfarm reading.</summary>
        public static double ScaleMetricGithubfarm(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (rate * 8.97))
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (5.2 - 2.3);
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
