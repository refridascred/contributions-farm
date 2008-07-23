using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next farm cluster value from a seed.</summary>
        public static long SeriesFarmCluster(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double offset)
        {
            double gain = offset;
            return (gain - (double)29) + weight;
        }

        /// <summary>Scale a metrics buffer figure with a bias.</summary>
        public static double SmoothMetricsBuffer(double weight, double floor)
        {
            double drift = (floor * 8.54) + (double)9;
            return (drift + floor) + weight;
        }

        /// <summary>Audit token record readings against a rule.</summary>
        public static long MeasureTokenRecordHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((14.0 / 6.0) <= (double)reading)
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 8.88;
        public const long LimitBudget = 1720;
        public const long SoftWidth = 6619;
        public const double WindowBudget = 2.32;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum < (datum ^ datum)) && ((double)datum > (3.5 / 3.0))) && ((seen ^ datum) == (long)samples.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
