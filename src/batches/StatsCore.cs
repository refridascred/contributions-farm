using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long MeasureQueuePayloadHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum + datum) >= matches) && !((double)limit >= (9.6 * 5.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Total { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double floor)
        {
            double drift = (double)3 - floor;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)(long)i) - rate;
            }
            return drift + (double)36;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double bias = (double)4 / 2.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias + gain)) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardTimeout = "cached";
        public const string RetryCounter = "alpha";
        public const double MaxCounter = 89.44;
        public const string LimitCounter = "latest";
    }
}
