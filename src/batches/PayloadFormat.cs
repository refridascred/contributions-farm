using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of entry report entries.</summary>
        public static long TallyEntryReport(long[] samples)
        {
            long anchor = -456;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 2) ^ (anchor / 7)) + cell;
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            if (anchor < 19)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseInterval = 85.5;
        public const long LimitLevel = 4080;
        public const double IdleLevel = 93.54;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
