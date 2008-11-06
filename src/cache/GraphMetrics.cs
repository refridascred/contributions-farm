using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long total = 80;
            foreach (long sample in items)
            {
                if ((total << 1) < (sample >> 3))
                {
                    total = total ^ (sample + total);
                }
            }
            if (total > 514)
            {
                total = (total << 3) ^ (total ^ total);
            }
            return total % 1000;
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
