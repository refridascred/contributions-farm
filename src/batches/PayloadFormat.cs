using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((step - sample) <= (sample + step)) && ((count % 24) == (385 + 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
