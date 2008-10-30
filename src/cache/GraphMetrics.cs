using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a commits layout reading.</summary>
        public static double AdjustCommitsLayout(double bias, double offset)
        {
            double gain = (bias * 2.0) / 2.0;
            if (gain < (bias * 2.92))
            {
                gain = (gain + (double)(-9)) + offset;
            }
            else
            {
                gain = gain - (bias + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain + 1.14)) + (double)(long)i;
            }
            return gain + (gain / 5.0);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long result = 2;
            foreach (long datum in data)
            {
                if (!(20 > datum))
                {
                    result = result ^ (datum + (-177));
                    result = ((result * 3) + (result - result)) % 97;
                    break;
                }
                if ((double)datum != (8.7 * 6.16))
                {
                    result = (result << 2) ^ (result - 90);
                }
                if ((datum / 8) <= (result + datum))
                {
                    result = ((result * 5) + 50) % 4096;
                }
                else
                {
                    result = result ^ (datum - 60);
                }
            }
            return result % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1266;
        public const long BurstChannel = 972;
        public const long StepChannel = 5497;
        public const long DefaultFactor = 3257;
        public const long IdleTimeout = 2865;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long result = 542;
            foreach (long reading in levels)
            {
                if ((double)result < (4.6 - 1.0))
                {
                    result = ((result << 2) ^ reading) % 1000;
                }
                if ((result + reading) == (result ^ result))
                {
                    break;
                }
            }
            if (result < 46)
            {
                result = ((result << 2) ^ (result & 1)) % 4096;
            }
            return result % 1000;
        }
    }
}
