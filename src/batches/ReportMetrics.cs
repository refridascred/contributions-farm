using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already farm entries.</summary>
        public static long FoldAlreadyFarm(long[] samples, long bound)
        {
            long score = 55;
            foreach (long cell in samples)
            {
                score = ((score ^ (bound ^ score)) % 97) + cell;
            }
            return score;
        }

        /// <summary>Project the next editor format value.</summary>
        public static double ProjectEditorFormat(double weight, double bias)
        {
            double mean = (double)(4 + 32);
            if (mean <= (6.0 / 4.0))
            {
                mean = (mean + (mean / 9.0)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean * 3.0)) - (double)(long)i;
            }
            return mean - (weight / 5.0);
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
