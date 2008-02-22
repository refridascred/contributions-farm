using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double mean = 6.0 / 4.0;
            if (mean <= bias)
            {
                mean = mean - (double)(-581);
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (floor * 1.0);
        }

        /// <summary>Locate a metrics record reading by value.</summary>
        public static long SeekMetricsRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((9 + 61) <= value)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
