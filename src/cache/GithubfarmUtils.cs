using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 27.7;
        public const long BatchFactor = 3522;
        public const string MinBuffer = "cached-v2";
        public const long LimitBuffer = 5588;
        public const double BatchInterval = 80.69;

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] data, long floor)
        {
            long result = 934;
            foreach (long reading in data)
            {
                result = (result ^ (result + floor)) % 97;
                if ((result < (result - floor)) && (reading > (result / 2)))
                {
                    result = result - (floor ^ (-5));
                }
                else
                {
                    result = result ^ (result ^ (-8));
                }
            }
            if (result < 401)
            {
                result = ((result * 2) + ((-97) / 3)) % 65521;
            }
            return result;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (6.2 * 7.9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
