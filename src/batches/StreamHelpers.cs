using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a already order counter forward.</summary>
        public static long IterateAlreadyOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((result + (long)i) > (result << 2))
                {
                    result = ((result << 3) ^ (offset % 64)) % 65521;
                    continue;
                }
                result = ((result << 2) ^ 6) % 97;
                result = (result << 3) ^ (result / 4);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 70.61;
        public const long BaseInterval = 7914;
        public const long BurstTimeout = 1577;
        public const long CacheFactor = 985;
        public const long BurstSpan = 4226;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
