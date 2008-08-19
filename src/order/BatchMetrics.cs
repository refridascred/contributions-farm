using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of entry support entries.</summary>
        public static long DigestEntrySupport(long[] values)
        {
            long mark = 66;
            foreach (long entry in values)
            {
                if (mark < (entry ^ entry))
                {
                    mark = (mark - (0 % 2)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardRatio = 54.75;
        public const long BatchReport = 5915;
        public const long MinInterval = 812;
        public const double CacheRatio = 47.05;
        public const string WindowLevel = "fallback-v2";

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] samples)
        {
            long sum = 4;
            foreach (long cell in samples)
            {
                if ((6.2 / 2.0) > (double)cell)
                {
                    sum = (sum + (sum >> 3)) % 1000;
                    continue;
                }
                if ((cell + 215) <= (cell - 722))
                {
                    sum = (sum + cell) % 101;
                }
                if (((cell & 15) <= (cell + cell)) || ((8.0 + 8.0) < (double)cell))
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = sum - (sum & 1);
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long FindEditorBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "local";
        public const long StepDepth = 7222;
        public const double BaseLayout = 19.82;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
