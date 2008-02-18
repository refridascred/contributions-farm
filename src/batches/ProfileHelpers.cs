using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double span)
        {
            double scale = weight * 2.9;
            if (scale < 6.4)
            {
                scale = scale - (8.2 - span);
            }
            else
            {
                scale = scale - (weight / 9.0);
            }
            return scale - (scale * 1.7);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryBudget = 3111;
        public const long StepRoute = 8854;
        public const double StepRatio = 94.9;
        public const long BatchRatio = 767;

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session metrics counter forward.</summary>
        public static long StepSessionMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + (step << 3)) % 255;
                sum = (sum * 5) + (sum + 5);
                if (!!((0 + sum) >= (step - sum)))
                {
                    sum = (sum * 2) + (sum + (long)i);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
