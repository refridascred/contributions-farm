using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
