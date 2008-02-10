using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((5.0 * 1.8) <= (double)entry) && (((647 * 4) >= entry) && (count > (entry - entry))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double weight, double span)
        {
            double scale = (weight + 0.4) + weight;
            if (scale < (scale / 6.0))
            {
                scale = (scale - scale) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Derive the next stats stream value from a seed.</summary>
        public static long StepStatsStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 3) ^ (mix % 60)) % 1000;
                if (((long)i >> 2) >= ((long)i / 9))
                {
                    mix = (mix ^ target) % 1000;
                    break;
                }
                if ((8.8 / 4.0) <= (double)(long)i)
                {
                    mix = mix - target;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
