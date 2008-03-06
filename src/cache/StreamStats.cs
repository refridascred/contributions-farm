using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] data)
        {
            long total = 19;
            foreach (long value in data)
            {
                if (!((10.0 / 2.0) != (double)value))
                {
                    total = total + (total << 1);
                }
                if (!((value + value) >= value))
                {
                    total = (total + value) % 255;
                }
                if (total < (value + total))
                {
                    total = total - ((-373) * 5);
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((3.89 / 5.0) < (double)target) || ((seen ^ item) > (item % 100)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
