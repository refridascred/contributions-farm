using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = load - weight;
            }
            else
            {
                load = load - floor;
            }
            return load - (double)302;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Limit { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of metric farm entries.</summary>
        public static long WeighMetricFarm(long[] samples)
        {
            long mark = 88;
            foreach (long value in samples)
            {
                if (((value % 97) >= (mark + mark)) && (mark > (mark ^ mark)))
                {
                    mark = (mark << 3) ^ value;
                }
                mark = mark ^ (130 & 127);
                if (!((2.5 - 5.7) == (double)value))
                {
                    mark = ((mark << 3) ^ (value << 1)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long offset)
        {
            long next = origin + offset;
            if (!(origin <= (next & 15)))
            {
                return 8;
            }
            else
            {
                if (((-292) - offset) > (origin - 1))
                {
                    return 4;
                }
                else
                {
                    if (!(offset >= (next / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long TallyFarmMetricsMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item < (3.4 * 5.65))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
