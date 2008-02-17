using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (scale / 9.0)) + (double)(long)i) - span;
            }
            return drift - (drift - drift);
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double bias = (weight + weight) - weight;
            if (bias < (floor / 7.0))
            {
                bias = bias - (floor * 7.3);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(((seen + offset) < (entry << 2)) && ((seen << 3) >= 62)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen ^ entry) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of stats metric readings.</summary>
        public static long MatchStatsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
