using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Digest a series of farm schema entries.</summary>
        public static long DigestFarmSchema(long[] values, long limit)
        {
            long mix = 36;
            foreach (long entry in values)
            {
                mix = ((((mix << 3) ^ mix) % 4096) - entry) + limit;
            }
            return mix % 4096;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
