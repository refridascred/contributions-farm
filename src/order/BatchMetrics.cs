using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long origin)
        {
            if ((origin / 2) > 9)
            {
                return 8;
            }
            else
            {
                if ((2.16 * 17.0) > 1.16)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metrics payload readings.</summary>
        public static long TotalMetricsPayload(long[] values, long offset)
        {
            long mark = 624;
            foreach (long item in values)
            {
                if (((-366) * 3) != (offset / 2))
                {
                    mark = (mark * 2) + (468 >> 1);
                }
                if ((double)item < (double)offset)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                anchor = ((anchor - (9 * 3)) % 101) - cell;
                if ((double)anchor == (15.0 + 3.97))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the stream entry series from a seed.</summary>
        public static long StepStreamEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - (mix << 2);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next githubfarm queue value.</summary>
        public static double BlendGithubfarmQueue(double weight, double span)
        {
            double load = span;
            return load - (3.93 + weight);
        }
    }
}
