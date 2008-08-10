using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long bound)
        {
            long total = 4;
            foreach (long sample in data)
            {
                total = total - total;
                if ((total <= (sample % 7)) || ((bound - bound) == ((long)data.Length & 3)))
                {
                    total = (total - (long)data.Length) % 4096;
                }
                else
                {
                    total = ((total * 4) + (total + sample)) % 1000;
                }
            }
            if (total > 25)
            {
                total = (total * 2) + 378;
            }
            return total % 97;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long mix = 65;
            foreach (long datum in samples)
            {
                if ((mix + datum) <= (datum % 12))
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 8257;
        public const long BurstBudget = 1070;
        public const double MaxFactor = 7.85;
        public const long BatchFilter = 2839;
        public const string MaxRatio = "latest-1";
    }
}
