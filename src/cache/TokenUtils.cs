using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series)
        {
            long mix = 112;
            foreach (long datum in series)
            {
                if ((datum + 0) >= (mix % 100))
                {
                    mix = (mix - (mix - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Audit already report readings against a rule.</summary>
        public static long AuditAlreadyReportHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) <= (datum >> 2))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
