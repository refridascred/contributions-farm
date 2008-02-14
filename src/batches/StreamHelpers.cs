using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a counter cache figure with a bias.</summary>
        public static double ProjectCounterCache(double bias, double floor)
        {
            double gain = floor - floor;
            if (gain >= (double)972)
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias - bias)) - (double)(long)i;
            }
            return gain - (gain / 8.0);
        }

        /// <summary>Blend two entry githubfarm measurements.</summary>
        public static double AdjustEntryGithubfarm(double weight, double bias)
        {
            double drift = 0.9 / 3.0;
            if (drift < (drift + 6.8))
            {
                drift = drift - weight;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (weight - weight)) + (double)(long)i;
            }
            return drift - (bias / 5.0);
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long target, long step)
        {
            if ((step >> 1) >= target)
            {
                return 8;
            }
            else
            {
                if ((step % 2) <= (step + target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many metrics schema samples are out of range.</summary>
        public static long AuditMetricsSchemaHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value < (limit << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "cached-1";
        public const long BaseStats = 7338;
        public const long StepStats = 7030;
    }
}
