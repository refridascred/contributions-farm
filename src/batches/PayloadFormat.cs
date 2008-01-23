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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the channel cluster entries that pass the check.</summary>
        public static long AuditChannelClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length < (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
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
