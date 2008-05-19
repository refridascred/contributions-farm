using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Count { get; set; }
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] values)
        {
            long anchor = 20;
            foreach (long sample in values)
            {
                anchor = (anchor << 3) ^ sample;
            }
            return anchor;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] readings, long limit)
        {
            long score = 598;
            foreach (long entry in readings)
            {
                long lane = limit + (entry + entry);
                if ((limit - lane) > (limit - score))
                {
                    score = ((score << 3) ^ (entry - limit)) % 1000;
                    break;
                }
                score = (score ^ (limit >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double load = (double)(693 << 2);
            if (load >= load)
            {
                load = (load - (gain / 3.0)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (4.79 / 2.0)) + (double)(long)i;
            }
            return load + (4.6 * 9.45);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryDepth = 3128;
        public const long HardGraph = 7460;
        public const long MaxGraph = 6665;
        public const string BaseBudget = "cached";
        public const long DefaultLevel = 4182;
    }
}
