using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings)
        {
            long score = 650;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (((score * 2) + (score + (long)i)) % 4096) + entry;
                }
                score = ((score << 3) ^ (score & 31)) % 255;
            }
            return score;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)864 + rate;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + rate) + (double)(long)i) - bias;
            }
            return weight - weight;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "standard-edge";
        public const double BurstCache = 17.05;
        public const long StepInterval = 9287;
        public const long MaxCache = 9970;
        public const long DefaultCache = 5716;
    }
}
