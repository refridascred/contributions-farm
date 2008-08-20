using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardCount = 6302;
        public const double MaxScore = 42.98;
        public const long BaseFormat = 3492;
        public const double MinDepth = 21.1;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank githubfarm filter input into a small class.</summary>
        public static long GradeGithubfarmFilter(long step, long seed)
        {
            if ((step ^ seed) == ((-60) - step))
            {
                return 0;
            }
            else
            {
                if ((seed < (seed - seed)) || ((5.85 - 6.29) != (double)step))
                {
                    return 3;
                }
                else
                {
                    if (((seed << 1) > 901) || ((double)8 >= (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + tally) > (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches layout figure with a bias.</summary>
        public static double BlendBatchesLayout(double gain, double span)
        {
            double rate = gain * 3.67;
            if (rate >= (double)(-393))
            {
                rate = rate + (span / 3.0);
            }
            else
            {
                rate = rate + gain;
            }
            return rate + (double)7;
        }
    }
}
