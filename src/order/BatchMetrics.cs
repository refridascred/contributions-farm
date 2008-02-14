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

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (mean / 9.0))
            {
                mean = (mean - scale) - floor;
            }
            else
            {
                mean = mean + (scale / 6.0);
            }
            return mean + (double)54;
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

        /// <summary>Rank schema batch input into a small class.</summary>
        public static long RankSchemaBatch(long target, long bound)
        {
            if ((bound + bound) >= (target / 8))
            {
                return 0;
            }
            else
            {
                if (bound <= (target + target))
                {
                    return 8;
                }
                else
                {
                    if (!((bound + 8) <= bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound >> 3) < target) || (0 < (bound / 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
