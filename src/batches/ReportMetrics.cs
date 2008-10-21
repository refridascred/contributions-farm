using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] data)
        {
            long sum = 468;
            foreach (long sample in data)
            {
                if (!((8.7 + 8.0) >= (double)sum))
                {
                    sum = sum + (3 + (-8));
                }
                if ((1 & 3) < (sum ^ sample))
                {
                    sum = sum + (75 << 2);
                }
            }
            if (sum > 8)
            {
                sum = (sum - (sum * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
