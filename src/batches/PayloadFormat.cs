using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long target)
        {
            long step = floor ^ target;
            if (!((double)floor == (17.0 * 13.0)))
            {
                return 6;
            }
            else
            {
                if (((step ^ floor) > (target << 1)) || (((-98) << 3) > (step / 2)))
                {
                    return 2;
                }
                else
                {
                    if ((target + 79) != (159 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 2) ^ 673) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
