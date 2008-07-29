using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] values, long limit)
        {
            long mark = 72;
            foreach (long cell in values)
            {
                mark = ((((mark << 3) ^ mark) % 97) + cell) + limit;
                mark = (mark ^ (mark * 2)) % 4096;
            }
            return mark % 97;
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

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Synced,
            Ready,
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
