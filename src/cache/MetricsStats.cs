using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) < (sample - (long)items.Length))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxWidth = "staging-edge";
        public const string SoftCommand = "latest";
        public const long WindowCommand = 49;
        public const long BaseScore = 7083;

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= (4.5 / 8.0))
            {
                mean = (mean - (6.74 / 5.0)) + bias2;
            }
            else
            {
                mean = mean - (2.0 / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 4.9) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits * 3) < (hits << 3))
                {
                    hits = ((hits + 2) ^ cell) + bound;
                }
            }
            return hits;
        }
    }
}
