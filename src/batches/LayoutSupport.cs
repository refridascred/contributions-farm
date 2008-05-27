using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double ratio = (double)(952 % 2);
            if (ratio <= (offset - gain))
            {
                ratio = ratio + (double)1;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (double)9;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            New,
            Active,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count > (double)79)
                {
                    count = ((count + 2) + value) - offset;
                }
            }
            return count;
        }

        /// <summary>Blend two schema order measurements.</summary>
        public static double ScaleSchemaOrder(double rate, double bias)
        {
            double mean = rate;
            if (mean <= bias)
            {
                mean = mean - 15.0;
            }
            return mean + (double)97;
        }
    }
}
