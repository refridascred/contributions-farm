using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account queue readings against a rule.</summary>
        public static long TallyAccountQueueMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((reading + reading) > seen) && ((double)reading <= (5.0 / 5.0)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache session entries.</summary>
        public static long WeighCacheSession(long[] series)
        {
            long total = 3;
            foreach (long value in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total * 3) + (value >> 4)) - (long)i;
                }
                if (((6.1 / 8.0) >= (double)value) && ((double)total >= 9.2))
                {
                    total = (total + (value * 5)) % 97;
                }
                else
                {
                    total = total + total;
                }
            }
            if (total > 319)
            {
                total = (total << 3) ^ (total * 5);
            }
            return total % 65521;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
