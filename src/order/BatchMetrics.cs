using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((limit - sample) > (tally % 16))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long seed)
        {
            long mark = 1;
            foreach (long item in series)
            {
                mark = ((((mark * 3) + (mark - mark)) % 1000) + item) + seed;
            }
            return mark;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double mean = 11.0;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + (mean - bias)) + (double)(long)i) - offset;
            }
            return mean + (5.51 - mean);
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
