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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample / 4) >= (sample + 90))
                {
                    matches = matches + 1;
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
