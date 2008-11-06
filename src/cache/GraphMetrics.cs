using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((count << 1) != (count - count)))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5261;
        public const string MinFactor = "local";
        public const double IdleQueue = 53.11;
        public const long SoftQueue = 7534;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 9300;
        public const long SoftRoute = 3675;
        public const long WindowBudget = 9000;
        public const long SoftCount = 9610;

        /// <summary>Digest a series of metric graph entries.</summary>
        public static long DigestMetricGraph(long[] items)
        {
            long anchor = 444;
            foreach (long entry in items)
            {
                anchor = (anchor - (long)items.Length) % 65521;
                if (anchor > entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next graph cluster value from a seed.</summary>
        public static long DeriveGraphCluster(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if ((total ^ (long)i) == ((long)i - total))
                {
                    total = ((total << 3) ^ (total >> 1)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
