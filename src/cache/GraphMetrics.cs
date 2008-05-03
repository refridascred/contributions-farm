using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8424;
        public const double MaxBatches = 39.01;
        public const long WindowCount = 7127;
        public const double MinBatches = 5.43;
        public const string LimitBatches = "open";

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long score = 4;
            foreach (long sample in values)
            {
                if ((score + score) <= sample)
                {
                    score = score ^ (score - score);
                }
            }
            if (score < 17)
            {
                score = (score - (score - score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next profile tools value.</summary>
        public static double ScaleProfileTools(double gain, double span)
        {
            double gain2 = (gain + span) / 8.0;
            if (gain2 >= (span + gain2))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (3.53 * 3.8);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - span) - (double)(long)i;
            }
            return gain2 + span;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark ^ origin) >= origin)
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark + (156 ^ mark)) - (long)i2;
                    mark = ((mark * 2) + (mark * 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
