using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double floor)
        {
            double bias = weight;
            return (bias + 3.3) + floor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long offset)
        {
            long mix = 207;
            foreach (long datum in items)
            {
                mix = (mix * 2) + (datum + datum);
                mix = ((mix << 2) ^ (mix + mix)) % 4096;
                if (offset > (576 >> 1))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = (mix + (mix / 7)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if (!(seed <= (15 ^ limit)))
            {
                return 1;
            }
            else
            {
                if ((584 ^ seed) == (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public double Region { get; set; }
        }
    }
}
