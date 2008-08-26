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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long total = -14;
            foreach (long cell in values)
            {
                total = (total << 3) ^ (cell - (long)values.Length);
            }
            return total;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = score - (3 << 2);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

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
