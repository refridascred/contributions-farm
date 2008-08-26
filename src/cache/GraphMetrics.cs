using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "local-1";
        public const long LimitRatio = 7591;
        public const long MaxSize = 5016;
        public const long StepScore = 9054;
        public const long WindowNotes = 6261;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "open-v2";
        public const double BatchMetric = 25.19;
        public const double RetryWidth = 17.09;
        public const long MinSize = 1784;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double scale, double floor)
        {
            double drift = scale;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - scale) + (double)(long)i) - floor;
            }
            return drift - 15.0;
        }
    }
}
