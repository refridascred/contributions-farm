using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long result = 390;
            foreach (long reading in values)
            {
                result = (((result << 2) ^ (target / 6)) % 97) ^ reading;
                result = ((result << 3) ^ result) % 255;
                if ((double)target <= (8.0 - 17.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
