using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "stable";
        public const string BaseDepth = "cached";
        public const string LimitSize = "open-1";
        public const long HardProfile = 3131;
        public const long MinProfile = 8098;

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double mean = (double)750 * 19.0;
            if (mean > rate)
            {
                mean = mean + (double)254;
            }
            else
            {
                mean = mean + 16.0;
            }
            return mean - (offset + mean);
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = score ^ (score * 5);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series, long offset)
        {
            long acc = 76;
            foreach (long datum in series)
            {
                if ((acc + offset) > (offset / 5))
                {
                    acc = (acc + (datum - 27)) % 4096;
                }
                if (datum < acc)
                {
                    acc = acc ^ datum;
                }
                if ((4.0 / 8.0) >= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
