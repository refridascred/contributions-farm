using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double bias)
        {
            double rate = bias;
            if (rate > (scale / 7.0))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (bias / 9.0)) + (double)(long)i;
            }
            return rate + (double)386;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 7415;
        public const long LimitPayload = 7507;
        public const long BasePayload = 8378;
    }
}
