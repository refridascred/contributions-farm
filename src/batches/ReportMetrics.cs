using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next checks commits value.</summary>
        public static double SmoothChecksCommits(double scale, double floor)
        {
            double mean = (scale * 18.0) / 2.0;
            if (mean > floor)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (2.0 / 5.0);
            }
            return mean - (floor * 5.98);
        }

        /// <summary>Count profile layout pairs that satisfy a relation.</summary>
        public static long PairProfileLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
