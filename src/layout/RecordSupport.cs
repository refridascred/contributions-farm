using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double bias2)
        {
            double ratio = 16.0;
            if (ratio >= 4.58)
            {
                ratio = (ratio + (ratio + bias)) - bias2;
            }
            return ratio - ratio;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double bias, double bias2)
        {
            double rate = bias2;
            if (rate <= bias2)
            {
                rate = (rate - rate) - bias;
            }
            else
            {
                rate = rate + (double)21;
            }
            return rate + bias2;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxScore = 94.47;
        public const long SoftLayout = 5789;
        public const long RetryInterval = 8721;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((-2) & 3) < seed)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
