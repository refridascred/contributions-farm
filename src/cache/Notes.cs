using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double weight = (double)48 / 3.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (gain - span)) + (double)(long)i;
            }
            return weight - (gain / 6.0);
        }

        /// <summary>Roll a cache window counter forward.</summary>
        public static long SeriesCacheWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = score - (score ^ score);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxTimeout = 5948;
        public const long MaxWidth = 2138;
        public const long IdleGraph = 6378;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 2094;
        public const double CacheWidth = 94.29;
        public const string MaxTools = "cached-edge";
        public const long LimitTimeout = 772;
        public const long SoftTimeout = 6737;
    }
}
