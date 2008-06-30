using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate record channel samples.</summary>
        public static long FoldRecordChannel(long[] values, long seed)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if ((0 & 7) >= (seed & 15))
                {
                    total = ((total * 5) + cell) % 97;
                }
            }
            return total;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double bias = floor / 6.0;
            return bias + (bias - gain);
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double bias = (floor + 0.7) * 2.0;
            return bias - (ratio / 5.0);
        }
    }
}
