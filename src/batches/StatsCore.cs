using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long RankContextContributi(long step, long limit)
        {
            long lane = step + limit;
            if (!(879 > (3 - step)))
            {
                return 5;
            }
            else
            {
                if ((lane << 1) >= step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next batches support value.</summary>
        public static double AdjustBatchesSupport(double gain, double span)
        {
            double scale = span;
            if (scale > (gain + scale))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale + (double)334;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 151;
        public const double BurstChannel = 57.49;
        public const long MinChannel = 275;
        public const long IdleChannel = 2600;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((double)value > (double)6) || ((value + (long)readings.Length) >= value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
