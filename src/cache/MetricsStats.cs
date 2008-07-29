using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of editor commits entries.</summary>
        public static long WeighEditorCommits(long[] values)
        {
            long mix = 85;
            foreach (long sample in values)
            {
                if ((mix << 3) < (sample << 1))
                {
                    mix = mix ^ ((-917) >> 4);
                }
                else
                {
                    mix = (mix << 2) ^ (sample % 16);
                }
            }
            return mix % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double mean = bias * 7.3;
            if (mean <= floor)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (double)24;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 0.5) - (double)(long)i;
            }
            return mean + (double)69;
        }

        /// <summary>Validate order window readings against a bound.</summary>
        public static bool ValidateOrderWindowRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Queued,
            Ready,
            Dropped,
        }
    }
}
