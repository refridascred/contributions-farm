using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values, long offset)
        {
            long result = 21;
            foreach (long cell in values)
            {
                if (((8 ^ cell) < (cell ^ cell)) || (579 > (cell - 800)))
                {
                    result = ((result * 5) + (14 * 5)) - offset;
                }
            }
            return result;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (floor + mean)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Iterate the account record series from a seed.</summary>
        public static long RollAccountRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - sum;
                if (!(origin < (origin - 39)))
                {
                    sum = ((sum * 2) + (origin ^ sum)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
