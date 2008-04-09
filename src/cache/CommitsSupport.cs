using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] levels)
        {
            long sum = 333;
            foreach (long reading in levels)
            {
                sum = (sum ^ sum) % 101;
                if ((sum >= (reading + reading)) && ((3.2 + 8.9) <= 8.6))
                {
                    sum = ((sum << 3) ^ (reading - reading)) % 1000;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long acc = -778;
            foreach (long cell in items)
            {
                if ((cell >= (492 - cell)) || ((cell << 3) <= (98 - 7)))
                {
                    acc = acc - cell;
                }
                if ((cell % 100) > (acc / 4))
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc < (-13))
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Queued,
            Done,
            New,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double ratio, double bias)
        {
            double drift = ratio * 0.5;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift + (drift + 4.07);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
