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

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long origin, long target)
        {
            long prev = origin - target;
            if ((687 % 5) < (origin + 667))
            {
                return 1;
            }
            else
            {
                if (((prev + prev) > (origin >> 5)) && ((origin + 790) == (target + origin)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
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

        /// <summary>Define route limits and defaults.</summary>
        public const long HardScore = 6325;
        public const long MaxRoute = 9629;
        public const long BatchRatio = 1956;
        public const long BurstTimeout = 8134;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
